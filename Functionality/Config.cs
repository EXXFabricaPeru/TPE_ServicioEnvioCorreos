using EXX_WinService.Core;
using EXX_WinService.Entities;
using EXX_WinService.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Functionality
{
    class Config
    {
        public static void Obtener(CONF origen)
        {
            try
            {
                //EXX_AIIR_CONF oConfig = new EXX_AIIR_CONF();

                var oConfig = ServiceLayer.Find<EXX_FECONF>(origen, new Tuple<string, string, string>("Code", Globals.Operador.Igual, "01"));

                if (oConfig.Count > 0)
                {
                    Globals.Host = oConfig[0].U_EXX_SFTPIP;
                    Globals.Port = Convert.ToInt32(oConfig[0].U_EXX_SPUERTO);
                    Globals.User = oConfig[0].U_EXX_SUSER;
                    Globals.Password = oConfig[0].U_EXX_SPASS;
                    Globals.EmailSubject = oConfig[0].U_EXX_ASUNTOMAIL;
                    Globals.EmailBody = oConfig[0].U_EXX_CUERPOMAIL;
                    Globals.SeriesAnexo = oConfig[0].U_EXX_SERIE.Split(';').ToList();

                    Globals.PathProcesado = ConfigurationManager.AppSettings["PathLogProcesados"].ToString();
                    Globals.HostAnx = ConfigurationManager.AppSettings["Host"].ToString();
                    Globals.PortAnx = Convert.ToInt32(ConfigurationManager.AppSettings["Port"].ToString());
                    Globals.UserAnx = ConfigurationManager.AppSettings["User"].ToString();
                    Globals.PasswordAnx = ConfigurationManager.AppSettings["Password"].ToString();
                }
                else
                    throw new Exception("No se encontró la configuración, por favor revise en SAP la tabla EXX_FECONF y registre los parámetros con el código '01'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
