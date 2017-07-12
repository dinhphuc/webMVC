using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webMVC_All.Models;


namespace webMVC_All.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        //
        // GET: /Admin/AdminHome/
        public ActionResult Index()
        {
            ItemRespont ITres = new ItemRespont();
            List<Item> lst = ITres.GetAllData();
            ViewData["listData"] = lst;
            return View();
;
        }
	}
}