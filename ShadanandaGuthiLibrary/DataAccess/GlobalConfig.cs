using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ShadanandaGuthiLibrary.DataAccess
{
    public static class GlobalConfig
    {
        public static string ConnString()
        {
            return ConfigurationManager.ConnectionStrings["Guthi"].ConnectionString;
        }
    }
}
