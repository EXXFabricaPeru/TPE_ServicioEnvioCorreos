using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Entities
{
    public class Viaje
    {
        [JsonProperty("nroPedido")] public string nroPedido { get; set; }
        [JsonProperty("nroTarea")] public string nroTarea { get; set; }
    }

    public class ViajeResponse
    {
        [JsonProperty("codigoViaje")] public string codigoViaje { get; set; }
        [JsonProperty("nroTarea")] public string nroTarea { get; set; }
        [JsonProperty("estadoViaje")] public string estadoViaje { get; set; }
    }
}
