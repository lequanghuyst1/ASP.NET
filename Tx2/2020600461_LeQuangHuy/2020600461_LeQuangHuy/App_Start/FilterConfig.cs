﻿using System.Web;
using System.Web.Mvc;

namespace _2020600461_LeQuangHuy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
