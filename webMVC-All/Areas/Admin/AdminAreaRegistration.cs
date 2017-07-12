﻿using System.Web.Mvc;

namespace webMVC_All.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new {  controller = "Login" ,action = "index", id = UrlParameter.Optional }
            );
        }
    }
}