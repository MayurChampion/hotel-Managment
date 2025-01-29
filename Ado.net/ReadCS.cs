using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Ado.net
{
    public class ReadCS
    {
        public static string ASPDB
        { 
            get
            {
                return ConfigurationManager.ConnectionStrings["ASPDBCS"].ConnectionString;
            }
        }
    }
}