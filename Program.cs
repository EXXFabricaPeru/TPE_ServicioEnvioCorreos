using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static void Main()
        {
            if (Environment.UserInteractive)
            {
                Core.Main oApp;
                try
                {
                    oApp = new Core.Main();
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    GC.Collect();
                }
            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new ServiceSincro()
                };
                ServiceBase.Run(ServicesToRun);
            }
        }
    }
}
