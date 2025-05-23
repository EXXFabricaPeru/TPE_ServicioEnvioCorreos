using EXX_WinService.Entities;
using EXX_WinService.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Core
{
    public class Globals
    {
        public static EventLog oEventLog = new EventLog();
        public static string configPath = AppDomain.CurrentDomain.BaseDirectory + "/SetupFields/";
        public static List<CONF> ListConfig = new List<CONF>();
        public static CONF MainConfig = new CONF();
        public static bool OnlyURI = false;
        public static bool SuccessInstall = true;
        public static List<string> CamposNumericos = new List<string> { "FolioNumber", "DocEntry", "DocNum", "Invoices/DocEntry", "Invoices/DocumentLines/BaseEntry" };
        public static string Token = string.Empty;
        public static string EmailSubject = string.Empty;
        public static string EmailBody = string.Empty;

        public static string Host = string.Empty;
        public static int Port = 0;
        public static string User = string.Empty;
        public static string Password = string.Empty;

        public static string HostAnx = string.Empty;
        public static int PortAnx = 0;
        public static string UserAnx = string.Empty;
        public static string PasswordAnx = string.Empty;
        public static List<string> SeriesAnexo;

        public static string PathProcesado = "C:\\archivos txt\\EstadoProcesado\\";
        public static class Operador
        {
            public const string Igual = " eq ";
            public const string Diferente = " ne ";
            public const string Mayor = " rq ";
            public const string Menor = " lq ";
            public const string MayorIgual = " ge ";
            public const string MenorIgual = " le ";
        }

        public static void RegistrarSource()
        {
            try
            {
                if (!EventLog.SourceExists("EXX_WinService"))
                {
                    EventLog.CreateEventSource("EXX_WinService", "Application");
                }
                oEventLog.Source = "EXX_WinService";
            }
            catch (Exception ex)
            {

            }
        }

        public static void SuccessMessage(string message)
        {
            Globals.oEventLog.WriteEntry(message, EventLogEntryType.SuccessAudit);
        }

        public static void InformationMessage(string message)
        {
            Globals.oEventLog.WriteEntry(message, EventLogEntryType.Information);
        }

        public static void ErrorMessage(string message)
        {
            Globals.oEventLog.WriteEntry(message, EventLogEntryType.Error);
        }

        public static void GetConfigBD()
        {
            try
            {
                ListConfig = Globals.ReadJson<CONF>("Config.json");

                ListConfig.ForEach(x =>
                {
                    x.b1slLogin = new B1SLLogin { CompanyDB = x.BaseDeDatos, UserName = x.Usuario, Password = x.Contrasena };
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"CONF: {ex.ToString()}");
            }
        }

        public static List<T> ReadJson<T>(string FileName) where T : class, new()
        {
            try
            {
                if (System.IO.File.Exists(configPath + FileName))
                {
                    string jsonContent = System.IO.File.ReadAllText(configPath + FileName);
                    JArray contentArray = JArray.Parse(jsonContent);
                    return contentArray.ToObject<List<T>>();
                }
                else
                    throw new Exception($"Archivo {FileName} no encontrado.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string ValidaConexion(CONF conn)
        {
            try
            {
                return ServiceLayer.Login(conn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static string BuildFilter(Tuple<string, string, string>[] prms)
        {
            try
            {
                string uri = string.Empty;
                if (prms != null && prms.Count() > 0)
                {
                    uri += string.Join(" and ", prms.ToList().Select(f =>
                        f.Item3 == null ? $"{f.Item1} {f.Item2} null"
                        : Globals.CamposNumericos.Any(x => x == f.Item1) ? $"{f.Item1} {f.Item2} {f.Item3}"
                        : IsNumeric(f.Item3)
                        ? $"{f.Item1} {f.Item2} '{f.Item3}'"
                        : $"{f.Item1} {f.Item2} '{f.Item3}'"
                    ));
                }

                return uri;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool IsNumeric(string value)
        {
            return double.TryParse(value, out _);
        }

        public static string BuildURI<T>(T @object)
        {
            try
            {
                var type = typeof(T);
                string uri = string.Empty;
                // Obtener el atributo SAPEntityName
                var entityAttribute = (SAPEntityNameAttribute)Attribute.GetCustomAttribute(type, typeof(SAPEntityNameAttribute));
                if (entityAttribute == null)
                {
                    throw new Exception("El atributo SAPEntityName no está definido en la clase.");
                }

                // Obtener la propiedad marcada con SAPKey
                var sapKeyProperty = type.GetProperties().FirstOrDefault(prop => Attribute.IsDefined(prop, typeof(SAPKeyAttribute)));
                if (sapKeyProperty == null)
                    return entityAttribute.Uri;

                if (Globals.OnlyURI)
                    return entityAttribute.Uri;

                // Obtener el valor de la propiedad SAPKey
                var sapKeyValue = sapKeyProperty.GetValue(@object)?.ToString();
                if (string.IsNullOrEmpty(sapKeyValue))
                    return entityAttribute.Uri;
                else
                {
                    sapKeyValue = IsNumeric(sapKeyValue) ? sapKeyValue : $"'{sapKeyValue}'";
                    if (entityAttribute.Uri == "SQLQueries")
                        return $"{entityAttribute.Uri}({sapKeyValue})/List";
                    else
                        return $"{entityAttribute.Uri}({sapKeyValue})";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Globals.OnlyURI = false;
            }
        }

        public static JsonSerializerSettings Settings<T>()
        {
            var settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new DynamicConverter<T>() },
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            return settings;
        }

        //public static void CleanJson<T>(ref T @object)
        //{
        //    try
        //    {
        //        var type = typeof(T);
        //        var entityAttribute = (SAPEntityNameAttribute)Attribute.GetCustomAttribute(type, typeof(SAPEntityNameAttribute));
        //        switch (entityAttribute.Uri)
        //        {
        //            case "Items":
        //                OITM item = (OITM)(object)@object;
        //                item.ItemWarehouseInfoCollection = null;
        //                break;
        //            case "BusinessPartners":
        //                var buesineesPartner = (OCRD)(object)@object;
        //                buesineesPartner.HouseBank = null;
        //                buesineesPartner.HouseBankCountry = null;
        //                buesineesPartner.HouseBankAccount = null;
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static DateTime ParseDateString(string dateString)
        {
            string[] formatos = {
                "MM/dd/yyyy HH:mm:ss",
                "dd/MM/yyyy HH:mm:ss",
                "yyyy-MM-dd HH:mm:ss",
                "MM/dd/yyyy",
                "dd/MM/yyyy",
                "yyyy-MM-dd"
                };

            DateTime fecha;

            // Intenta convertir usando los formatos especificados
            if (DateTime.TryParseExact(dateString, formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
            {
                return fecha;
            }
            else
            {
                throw new FormatException($"El formato de la fecha '{dateString}' no es válido.");
            }
        }
    }
}
