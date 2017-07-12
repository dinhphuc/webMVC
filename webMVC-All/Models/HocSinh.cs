using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using webMVC_All.Helper;

namespace webMVC_All.Models
{
    public class HocSinh
    {
        public int HSID { get; set; }
        public string Name { get; set; }
        public string QQ { get; set; }


        public void SetDataRow(DataRow dr)
        {
            this.HSID = int.Parse(dr["HSID"].ToString());
            this.Name = dr["Name"].ToString();
            this.QQ = dr["QQ"].ToString();     
        }
        
    }
}