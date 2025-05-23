using EXX_WinService.Core;
using EXX_WinService.Entities;
using EXX_WinService.Framework;
using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Functionality
{
    public class NotaCredito
    {
        public static void Actualizar(CONF origen, List<string> datos)
        {
            try
            {
                var ContentList = ServiceLayer.Find<ORIN>(origen, new Tuple<string, string, string>("FolioPrefixString", Globals.Operador.Igual, datos[2].Substring(0, 4))
                                                                , new Tuple<string, string, string>("FolioNumber", Globals.Operador.Igual, Convert.ToInt32(datos[2].Substring(4, 8)).ToString()));

                if (ContentList.Count > 0)
                {
                    ORIN oNotaCredito = new ORIN();
                    oNotaCredito.DocEntry = ContentList[0].DocEntry;

                    if (oNotaCredito.U_SMC_ESTADO_FE != "02")
                    {
                        if (datos[4] == "1")
                        {
                            oNotaCredito.U_SMC_ESTADO_FE = "02";
                            oNotaCredito.U_SMC_MSJ_ESTADO_FE  = datos[5].Length > 150 ? datos[5].Substring(0, 150) : datos[5];
                        }
                        else
                        {
                            oNotaCredito.U_SMC_ESTADO_FE = "03";
                            oNotaCredito.U_SMC_MSJ_ESTADO_FE = datos[5].Length > 150 ? datos[5].Substring(0, 150) : datos[5];
                        }
                        ServiceLayer.Update<ORIN>(origen, oNotaCredito);
                    }
                }
            }
            catch (Exception ex)
            {
                Globals.ErrorMessage(ex.Message);
            }
        }

        public static void EnviarCorreo(CONF conn)
        {
            try
            {
                var ContentList = ServiceLayer.Find<ORIN>(conn, new Tuple<string, string, string>("U_SMC_ESTADO_FE", Globals.Operador.Igual, "02")
                                                               , new Tuple<string, string, string>("U_EXX_FE_MailEnviado", Globals.Operador.Igual, "NO"));

                if (ContentList.Count > 0)
                {
                    var clienteSMTP = ConfigurationManager.AppSettings["ClientSMTP"].ToString();
                    var puertoSMTP = Convert.ToInt32(ConfigurationManager.AppSettings["PortSMTP"].ToString());
                    string usuarioCorreo = ConfigurationManager.AppSettings["UserMail"].ToString();
                    var claveCorreo = ConfigurationManager.AppSettings["PasswordMail"].ToString();

                    foreach (var item in ContentList)
                    {
                        try
                        {
                            ORIN doc = ServiceLayer.FindById<ORIN>(conn, item);
                            ORIN NotaCredito = new ORIN();
                            NotaCredito.DocEntry = doc.DocEntry;
                            OATC anexos = new OATC();
                            anexos.AbsoluteEntry = Convert.ToInt32(doc.AttachmentEntry);
                            anexos = ServiceLayer.FindById<OATC>(conn, anexos);

                            if (anexos.Attachments2_Lines.Count >= 2)
                            {
                                OCRD Cliente = new OCRD();
                                Cliente.CardCode = item.CardCode;
                                Cliente = ServiceLayer.FindById<OCRD>(conn, Cliente);

                                string body = Globals.EmailBody;
                                body = body.Replace("@cliente", Cliente.CardName);

                                var email = new MimeMessage();
                                email.From.Add(MailboxAddress.Parse(usuarioCorreo));
                                //var correos = correoDestino.Split(';').ToList();
                                var correos = usuarioCorreo.Split(';').ToList().ToList();
                                correos.ForEach(x => email.To.Add(MailboxAddress.Parse(x.Trim())));
                                email.Subject = Globals.EmailSubject;
                                email.Body = new TextPart(TextFormat.Html) { Text = body };

                                var multipart = new Multipart("mixed");
                                multipart.Add(email.Body);

                                foreach (var anexo in anexos.Attachments2_Lines)
                                {
                                    byte[] archivoAdjunto = File.ReadAllBytes(anexo.SourcePath + "\\" + anexo.FileName);
                                    string extension = anexo.FileName.Substring(anexo.FileName.LastIndexOf('.') + 1, anexo.FileName.Length - (anexo.FileName.LastIndexOf('.') + 1));
                                    var adjunto = new MimePart("application", extension)
                                    {
                                        Content = new MimeContent(new MemoryStream(archivoAdjunto), ContentEncoding.Default),
                                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                                        ContentTransferEncoding = ContentEncoding.Base64,
                                        FileName = Cliente.CardCode.Replace("C", "") + "-" + doc.Indicator + "-" + doc.FolioPrefixString + "-" + doc.FolioNumber + "." + extension
                                    };
                                    multipart.Add(adjunto);
                                }

                                email.Body = multipart;
                                using (var client = new MailKit.Net.Smtp.SmtpClient())
                                {
                                    client.Connect(clienteSMTP, puertoSMTP, SecureSocketOptions.StartTls);
                                    client.Authenticate(usuarioCorreo, claveCorreo);
                                    client.Send(email);
                                    client.Disconnect(true);
                                }

                                NotaCredito = new ORIN();
                                NotaCredito.DocEntry = item.DocEntry;
                                NotaCredito.U_EXX_FE_MailEnviado = "SI";
                                NotaCredito.U_SMC_MSJ_ESTADO_EM = "Email enviado correctamente";
                                ServiceLayer.Update<ORIN>(conn, NotaCredito);
                            }
                            else
                                throw new Exception("EMAIL: no se encontró los adjuntos en el documento SAP");
                        }
                        catch (Exception ex)
                        {
                            ORIN Factura = new ORIN();
                            Factura.DocEntry = item.DocEntry;
                            Factura.U_SMC_MSJ_ESTADO_FE = ex.Message;
                            ServiceLayer.Update<ORIN>(conn, Factura);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Globals.ErrorMessage(ex.Message);
            }
        }
    }
}
