using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using webMVC_All.Helper;

namespace webMVC_All.Models
{
    public class ItemRespont
    {
        public List<Item> GetAllData()
        {
            DataTable dt = sqlHelper.Query("select *from ItemFull");
            if (dt == null) return null;
            if (dt.Rows.Count > 0)
            {
                List<Item> ItemList = new List<Item>();
                foreach (DataRow dr in dt.Rows)
                {
                    Item It = new Item();
                    It.SetDataRow(dr);
                    ItemList.Add(It);
                }
                return ItemList;
            }
            else return null;
        }
        public Item GetDataByID(int ID)
        {
            DataTable dt = sqlHelper.Query("select *from ItemFull where ItemID=" + ID.ToString());
            if (dt.Rows.Count == 1 )
            {
                Item It = new Item();
                It.SetDataRow(dt.Rows[0]);
                return It;
            }
            else return null;
        }



        public List<HocSinh> GetAllDataHS()
        {
            DataTable dt = sqlHelper.Query("select *from HocSinh");
            if (dt == null) return null;
            if (dt.Rows.Count > 0)
            {
                List<HocSinh> HocSinhHS = new List<HocSinh>();
                foreach (DataRow dr in dt.Rows)
                {
                    HocSinh HS = new HocSinh();
                    HS.SetDataRow(dr);
                    HocSinhHS.Add(HS);
                }
                return HocSinhHS;
            }
            else return null;
        }
    }
}