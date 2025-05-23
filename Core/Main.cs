using EXX_WinService.Entities;
using EXX_WinService.Framework;
using EXX_WinService.Functionality;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace EXX_WinService.Core
{
    public class Main
    {
        public Main()
        {
            DateTime StartSincro = new DateTime();
            try
            {
                Globals.RegistrarSource();
                Globals.InformationMessage("Obteniendo configuración de base de datos.");
                Globals.GetConfigBD();

                foreach (CONF conn in Globals.ListConfig)
                {
                    conn.SessionId = Globals.ValidaConexion(conn);
                    Config.Obtener(conn);
                    Factura.EnviarCorreo(conn);
                    NotaCredito.EnviarCorreo(conn);
                }
            }
            catch (Exception ex)
            {
                Globals.ErrorMessage(ex.Message);
            }
            finally
            {
                foreach (CONF item in Globals.ListConfig)
                    ServiceLayer.Logout(item);
            }
        }

        private void ActualizarEstado()
        {
            try
            {
                var client = new SftpClient(Globals.Host, Globals.Port, Globals.User, Globals.Password);
                client.Connect();
                if (client.IsConnected)
                {
                    var files = client.ListDirectory("/Estado/")
                            .Where(f => !f.IsDirectory && f.Name.EndsWith(".TXT")) // Filtrar solo archivos .txt
                            .Select(f => f.Name)
                            .ToList();

                    if (files.Count > 0)
                    {
                        foreach (var file in files)
                        {
                            using (var stream = new MemoryStream())
                            {
                                client.DownloadFile("/Estado/" + file, stream);
                                stream.Position = 0;

                                using (var fileStream = new FileStream(Globals.PathProcesado + file, FileMode.Create, FileAccess.Write))
                                {
                                    stream.CopyTo(fileStream);
                                }

                                stream.Position = 0;

                                using (var reader = new StreamReader(stream))
                                {
                                    List<string> lineas = new List<string>();

                                    string linea;
                                    while ((linea = reader.ReadLine()) != null)
                                    {
                                        if (linea.Contains("|"))
                                            lineas.Add(linea);
                                        else
                                            lineas[lineas.Count - 1] += linea;
                                    }

                                    // 🔹 Procesar cada línea y dividir por "|"
                                    foreach (var lineaTexto in lineas)
                                    {
                                        List<string> datos = lineaTexto.Split('|').ToList();
                                        switch (datos[1])
                                        {
                                            case "01":
                                            case "03":
                                                Factura.Actualizar(Globals.ListConfig[0], datos);
                                                break;
                                            case "07":
                                                NotaCredito.Actualizar(Globals.ListConfig[0], datos);
                                                break;
                                        }
                                    }
                                }
                            }
                            client.DeleteFile("/Estado/" + file);
                        }
                    }
                    client.Disconnect();
                }
                else
                {
                    throw new InvalidOperationException("No se pudo conectar con el servicio SFTP");
                }
            }
            catch (Exception ex)
            {
                Globals.ErrorMessage(ex.Message);
            }
        }
    }
}
