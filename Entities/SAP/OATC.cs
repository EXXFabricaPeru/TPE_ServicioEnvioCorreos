using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Entities
{
    [SAPEntityName("Attachments2")]
    public class OATC
    {
        [JsonProperty("AbsoluteEntry"), SAPKey] public int AbsoluteEntry { get; set; }
        [JsonProperty("Attachments2_Lines")] public List<ATC1> Attachments2_Lines { get; set; }
    }

    public class ATC1
    {
        [JsonProperty("Line")] public int Line { get; set; }
        [JsonProperty("SourcePath")] public string SourcePath { get; set; }
        [JsonProperty("FileName")] public string FileName { get; set; }
        [JsonProperty("FileExtension")] public string FileExtension { get; set; }
        [JsonProperty("AttachmentDate")] public DateTime? AttachmentDate { get; set; }
        [JsonProperty("UserID")] public int? UserID { get; set; }
        [JsonProperty("Override")] public string Override { get; set; }
    }
}