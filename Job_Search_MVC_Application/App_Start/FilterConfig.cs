﻿using System.Web;
using System.Web.Mvc;

namespace Job_Search_MVC_Application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
