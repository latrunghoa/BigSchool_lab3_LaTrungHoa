﻿using System.Web;
using System.Web.Mvc;

namespace lab3_LaTrungHoa
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
