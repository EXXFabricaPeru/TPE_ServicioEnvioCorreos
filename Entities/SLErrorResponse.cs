using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXX_WinService.Entities
{
    public class SLErrorResponse
    {
        public error Error { get; set; }
    }

    public class error
    {
        public string code { get; set; }
        public message Message { get; set; }
    }

    public class message
    {
        public string lang { get; set; }
        public string value { get; set; }
    }
}
