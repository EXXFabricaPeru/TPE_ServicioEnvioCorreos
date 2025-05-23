using EXX_WinService.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXX_WinService
{
    public partial class ServiceSincro : ServiceBase
    {
        public Thread workerThread;
        public ServiceSincro()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            workerThread = new Thread(DoWork);
            workerThread.Start();
        }

        protected override void OnStop()
        {
            if (workerThread != null && workerThread.IsAlive)
                workerThread.Abort();
        }

        private void DoWork()
        {
            while (true)
            {
                Main oApp;
                try
                {
                    oApp = new Main();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    GC.Collect();
                }
                Thread.Sleep(10000);
            }
        }
    }
}
