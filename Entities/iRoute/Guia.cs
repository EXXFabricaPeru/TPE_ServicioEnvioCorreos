using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Entities
{
    public class Guia
    {
        [JsonProperty("nroViaje")] public string nroViaje { get; set; }
        [JsonProperty("nroTarea")] public string nroTarea { get; set; }
        [JsonProperty("codicoClienteFinal")] public string codicoClienteFinal { get; set; }
        [JsonProperty("nroGuia")] public string nroGuia { get; set; }
        [JsonProperty("precioTotal")] public double precioTotal { get; set; }
    }
}
