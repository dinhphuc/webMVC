using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webMVC_All.Models;
namespace webMVC_All.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ItemRespont ITres = new ItemRespont();
            List<Item> lst = ITres.GetAllData();
            ViewData["listData"] = lst;
            return View();
        }
        public ActionResult Item(int ID)
        {
            ItemRespont ITres = new ItemRespont();
            Item IT = ITres.GetDataByID(ID);
            ViewData["Item"] = IT;
            return View();
        }


        public ActionResult HocSinh()
        {
            ItemRespont ITres = new ItemRespont();
            List<HocSinh> lst = ITres.GetAllDataHS();
            ViewData["listDataHS"] = lst;
            return View();
        }
	}
}