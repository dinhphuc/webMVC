using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace webMVC_All.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string NameItem { get; set; }
        public string LinkImg { get; set; }
        public string Pride { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string OperatingSystem { get; set; }
        public string Style { get; set; }
        public string StorageCapacity { get; set; }
        public string CameraResolution { get; set; }
        public string MemoryCardType { get; set; }
        public string RAM { get; set; }
        public string ScreenSize { get; set; }
        public string Processor { get; set; }
        public string CountryRegion { get; set; }
        public int Total { get; set; }



 
        public void SetDataRow (DataRow dr  )
        {
            this.ItemID = int.Parse(dr["ItemID"].ToString());
            this.NameItem = dr["NameItem"].ToString();
            this.LinkImg = dr["LinkImg"].ToString();
            this.Pride = dr["Pride"].ToString();
            this.Brand = dr["Brand"].ToString();
            this.Model = dr["Model"].ToString();
            this.OperatingSystem = dr["OperatingSystem"].ToString();
            this.Style = dr["Style"].ToString();
            this.StorageCapacity = dr["StorageCapacity"].ToString();
            this.CameraResolution = dr["CameraResolution"].ToString();
            this.MemoryCardType = dr["MemoryCardType"].ToString();
            this.RAM = dr["RAM"].ToString();
            this.ScreenSize = dr["ScreenSize"].ToString();
            this.Processor = dr["Processor"].ToString();
            this.CountryRegion = dr["CountryRegion"].ToString();
            this.Total = int.Parse(dr["Total"].ToString());
          
        }
       
    }
    
}