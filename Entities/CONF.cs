using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Entities
{
    [SAPEntityName("Login")]
    public class CONF
    {
        public bool Principal { get; set; }
        public string Url { get; set; }
        public string BaseDeDatos { get; set; }
        public string NombreSociedad { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string CodigoCliente { get; set; }
        public string CodigoProveedor { get; set; }
        public bool MigraSocio { get; set; }
        public bool MigraArticulo { get; set; }
        public string SessionId { get; set; }
        public B1SLLogin b1slLogin { get; set; }
    }

    public class B1SLLogin
    {
        public string CompanyDB { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
