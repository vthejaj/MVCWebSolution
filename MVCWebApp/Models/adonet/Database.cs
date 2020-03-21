using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MVCWebApp.Models.adonet
{
    public class Database
    {
        public static string MSDBConnectionString 
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["msdb"].ConnectionString;
            }
        }
    }
}