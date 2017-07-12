using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace webMVC_All.Helper
{
    public class sqlConnection
    {
        public static SqlConnection connection =
          new SqlConnection("server=PhucBinz\\SEAKBZ;database=WebMCV;integrated security=SSPI");
    }
}