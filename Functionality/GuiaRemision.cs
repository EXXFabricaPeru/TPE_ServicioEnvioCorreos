using EXX_WinService.Core;
using EXX_WinService.Entities;
using EXX_WinService.Framework;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace EXX_WinService.Functionality
{
    public class GuiaRemision
    {
        public static void Migrar(CONF origen)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Globals.ErrorMessage(ex.Message);
            }
        }
    }
}