using EXX_WinService.Core;
using EXX_WinService.Entities;
using EXX_WinService.Framework;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Renci.SshNet;
using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace EXX_WinService.Functionality
{
    public class Factura
    {
        public static void Actualizar(CONF origen, List<string> datos)
        {
            try
            {
                var ContentList = ServiceLayer.Find<OINV>(origen, new Tuple<string, string, string>("FolioPrefixString", Globals.Operador.Igual, datos[2].Substring(0, 4))
                                                                , new Tuple<string, string, string>("FolioNumber", Globals.Operador.Igual, Convert.ToInt32(datos[2].Substring(4, 8)).ToString()));

                if (ContentList.Count > 0)
                {
                    OINV oFactura = new OINV();
                    oFactura.DocEntry = ContentList[0].DocEntry;

                    if (oFactura.U_SMC_ESTADO_FE != "02")
                    {
                        if (datos[4] == "1")
                        {
                            oFactura.U_SMC_ESTADO_FE = "02";
                            oFactura.U_SMC_MSJ_ESTADO_EM = datos[5].Length > 150 ? datos[5].Substring(0, 150) : datos[5];
                        }
                        else
                        {
                            oFactura.U_SMC_ESTADO_FE = "03";
                            oFactura.U_SMC_MSJ_ESTADO_EM = datos[5].Length > 150 ? datos[5].Substring(0, 150) : datos[5];
                        }
                        ServiceLayer.Update<OINV>(origen, oFactura);
                    }
                    //Globals.SuccessMessage(oOrder.DocNum + " procesado correctamente.");
                }
                else
                {
                    var ContentList2 = ServiceLayer.Find<ODPI>(origen, new Tuple<string, string, string>("FolioPrefixString", Globals.Operador.Igual, datos[2].Substring(0, 4))
                                                                , new Tuple<string, string, string>("FolioNumber", Globals.Operador.Igual, Convert.ToInt32(datos[2].Substring(4, 8)).ToString()));

                    if (ContentList2.Count > 0)
                    {
                        ODPI oAnticipo = new ODPI();
                        oAnticipo.DocEntry = ContentList2[0].DocEntry;

                        if (oAnticipo.U_SMC_ESTADO_FE != "02")
                        {
                            if (datos[4] == "1")
                            {
                                oAnticipo.U_SMC_ESTADO_FE = "02";
                                oAnticipo.U_SMC_MSJ_ESTADO_FE = datos[5];
                            }
                            else
                            {
                                oAnticipo.U_SMC_ESTADO_FE = "03";
                                oAnticipo.U_SMC_MSJ_ESTADO_FE = datos[5];
                            }
                            ServiceLayer.Update<ODPI>(origen, oAnticipo);
                        }
                        //Globals.SuccessMessage(oOrder.DocNum + " procesado correctamente.");
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
                var ContentList = ServiceLayer.Find<OINV>(conn, new Tuple<string, string, string>("U_SMC_ESTADO_FE", Globals.Operador.Igual, "02")
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
                            OINV doc = ServiceLayer.FindById<OINV>(conn, item);
                            OINV Factura = new OINV();
                            Factura.DocEntry = doc.DocEntry;
                            OATC anexos = new OATC();
                            anexos.AbsoluteEntry = Convert.ToInt32(doc.AttachmentEntry);
                            anexos = ServiceLayer.FindById<OATC>(conn, anexos);

                            if (anexos != null && anexos.Attachments2_Lines != null)
                            {
                                if (anexos.Attachments2_Lines.Count >= 2)
                                {
                                    OCRD Cliente = new OCRD();
                                    Cliente.CardCode = doc.CardCode;
                                    Cliente = ServiceLayer.FindById<OCRD>(conn, Cliente);

                                    int pdf = anexos.Attachments2_Lines.Count(x => x.FileName.Contains(doc.Indicator + "_" + doc.FolioPrefixString + "_" + doc.FolioNumber.PadLeft(8, '0') + ".pdf"));
                                    int xml = anexos.Attachments2_Lines.Count(x => x.FileName.Contains(doc.Indicator + "_" + doc.FolioPrefixString + "_" + doc.FolioNumber.PadLeft(8, '0') + ".xml"));

                                    if (pdf == 0 || xml == 0)
                                        throw new Exception("EMAIL: no se encontró los adjuntos en el documento SAP");

                                    string body = Globals.EmailBody;
                                    body = body.Replace("@cliente", Cliente.CardName);

                                    var email = new MimeMessage();
                                    email.From.Add(MailboxAddress.Parse(usuarioCorreo));
                                    //var correos = Cliente.U_EXT_CORREO.Split(';').ToList();
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

                                    if (Globals.SeriesAnexo.Contains(doc.FolioPrefixString))
                                    {
                                        if (!string.IsNullOrEmpty(doc.U_EXT_dc_fact_Dvta_IntegradoGas))
                                        {
                                            string Path = string.Empty;
                                            string filename = string.Empty;
                                            string extension = string.Empty;
                                            var client = new SftpClient(Globals.HostAnx, Globals.PortAnx, Globals.UserAnx, Globals.PasswordAnx);
                                            client.Connect();
                                            byte[] archivoAdjuntoANX = null;

                                            if (client.IsConnected)
                                            {
                                                if (doc.U_EXT_dc_fact_Dvta_IntegradoGas == "Y")
                                                {
                                                    filename = doc.FolioPrefixString + doc.FolioNumber + ".xls";
                                                    Path = "//SUSTENTOS_INTEGRADOS//" + filename;
                                                    extension = "xls";
                                                }
                                                else
                                                {
                                                    filename = doc.U_EXT_OSNRO + ".PDF";
                                                    Path = "//SUSTENTOF002//" + filename;
                                                    extension = "PDF";
                                                }
                                                try
                                                {
                                                    using (var ms = new MemoryStream())
                                                    {
                                                        client.DownloadFile(Path, ms);
                                                        archivoAdjuntoANX = ms.ToArray();
                                                    }
                                                    client.Disconnect();
                                                }
                                                catch (Exception ex)
                                                {
                                                    client.Disconnect();
                                                    if (ex.Message == "No such file")
                                                        throw new Exception("EMAIL: no se encontró el adjunto del documento en el servidor SFTP");
                                                    else
                                                        throw new Exception("EMAIL: " + ex.Message);
                                                }

                                            }

                                            var adjuntoANX = new MimePart("application", extension)
                                            {
                                                Content = new MimeContent(new MemoryStream(archivoAdjuntoANX), ContentEncoding.Default),
                                                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                                                ContentTransferEncoding = ContentEncoding.Base64,
                                                FileName = filename
                                            };
                                            multipart.Add(adjuntoANX);
                                        }
                                        else
                                            throw new Exception("EMAIL: no se encontró información para el campo IntegradoGas");
                                    }

                                    Factura = new OINV();
                                    Factura.DocEntry = item.DocEntry;
                                    Factura.U_EXX_FE_MailEnviado = "SI";
                                    Factura.U_SMC_MSJ_ESTADO_EM = "Email enviado correctamente";
                                    ServiceLayer.Update<OINV>(conn, Factura);

                                    email.Body = multipart;
                                    using (var client = new MailKit.Net.Smtp.SmtpClient())
                                    {
                                        client.Connect(clienteSMTP, puertoSMTP, SecureSocketOptions.StartTls);
                                        client.Authenticate(usuarioCorreo, claveCorreo);
                                        client.Send(email);
                                        client.Disconnect(true);
                                    }
                                }
                                else
                                    throw new Exception("EMAIL: no se encontró los adjuntos en el documento SAP");
                            }
                            else
                                throw new Exception("EMAIL: no se encontró los adjuntos en el documento SAP");
                        }
                        catch (Exception ex)
                        {
                            try
                            {
                                OINV Factura = new OINV();
                                Factura.DocEntry = item.DocEntry;
                                Factura.U_SMC_MSJ_ESTADO_EM = ex.Message;
                                ServiceLayer.Update<OINV>(conn, Factura);
                                Globals.InformationMessage(ex.Message);
                            }
                            catch (Exception)
                            {
                            }
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
