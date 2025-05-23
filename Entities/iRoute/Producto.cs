using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Entities
{
    public class Producto
    {
        [JsonProperty("viajes")] public List<Viajes> Viajes { get; set; }
    }

    public class Viajes
    {
        [JsonProperty("codigoViaje")] public string CodigoViaje { get; set; }
        [JsonProperty("resanes")] public List<Resanes> Resanes { get; set; }
        [JsonProperty("entregas")] public List<Entregas> Entregas { get; set; }
    }

    public class Resanes
    {
        [JsonProperty("sku")] public string Sku { get; set; }
        [JsonProperty("cantidad")] public string Cantidad { get; set; }
        [JsonProperty("unidadPresentacion")] public string UnidadPresentacion { get; set; }
        [JsonProperty("descripcion")] public string Descripcion { get; set; }
    }

    public class Entregas
    {
        [JsonProperty("nroEntrega")] public string NroEntrega { get; set; }
        [JsonProperty("cliente")] public string Cliente { get; set; }
        [JsonProperty("documentoCobranza")] public List<DocumentoCobranza> documentoCobranza { get; set; }
    }

    public class DocumentoCobranza
    {
        [JsonProperty("tipo")] public string Tipo { get; set; }
        [JsonProperty("numero")] public string Numero { get; set; }
        [JsonProperty("precioTotal")] public string PrecioTotal { get; set; }
        [JsonProperty("productos")] public List<Productos> productos { get; set; }
    }

    public class Productos
    {
        [JsonProperty("sku")] public string Sku { get; set; }
        [JsonProperty("descripcion")] public string Descripcion { get; set; }
        [JsonProperty("cantidad")] public int Cantidad { get; set; }
        [JsonProperty("tipoProducto")] public string TipoProducto { get; set; }
        [JsonProperty("precioUnitario")] public double PrecioUnitario { get; set; }
        [JsonProperty("unidadPresentacion")] public string UnidadPresentacion { get; set; }
        [JsonProperty("unidadVenta")] public string UnidadVenta { get; set; }
        [JsonProperty("cantidadVenta")] public double CantidadVenta { get; set; }
        [JsonProperty("importe")] public double Importe { get; set; }
    }
}
