namespace EXX_WinService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.EXX_FE_ESTADO = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller1 = new System.ServiceProcess.ServiceInstaller();
            // 
            // EXX_FE_ESTADO
            // 
            this.EXX_FE_ESTADO.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.EXX_FE_ESTADO.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceInstaller1});
            this.EXX_FE_ESTADO.Password = null;
            this.EXX_FE_ESTADO.Username = null;
            // 
            // serviceInstaller1
            // 
            this.serviceInstaller1.Description = "Actualiza estado Sunat y envía correos";
            this.serviceInstaller1.DisplayName = "EXX_FE_ESTADO";
            this.serviceInstaller1.ServiceName = "EXX_FE_ESTADO";
            this.serviceInstaller1.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.EXX_FE_ESTADO});

        }

        #endregion
        public System.ServiceProcess.ServiceProcessInstaller EXX_FE_ESTADO;
        public System.ServiceProcess.ServiceInstaller serviceInstaller1;
    }
}