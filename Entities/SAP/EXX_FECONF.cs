using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Entities
{
    [SAPEntityName("U_EXX_FECONF")]
    public class EXX_FECONF
    {
        [JsonProperty("Code"), SAPKey] public string Code { get; set; }
        [JsonProperty("Name")] public string Name { get; set; }
        [JsonProperty("U_EXX_SFTPIP")] public string U_EXX_SFTPIP { get; set; }
        [JsonProperty("U_EXX_SPUERTO")] public string U_EXX_SPUERTO { get; set; }
        [JsonProperty("U_EXX_SUSER")] public string U_EXX_SUSER { get; set; }
        [JsonProperty("U_EXX_SPASS")] public string U_EXX_SPASS { get; set; }
        [JsonProperty("U_EXX_ASUNTOMAIL")] public string U_EXX_ASUNTOMAIL { get; set; }

        [JsonProperty("U_EXX_CUERPOMAIL")] public string U_EXX_CUERPOMAIL { get; set; }
        [JsonProperty("U_EXX_SERIE")] public string U_EXX_SERIE { get; set; }
    }
}
