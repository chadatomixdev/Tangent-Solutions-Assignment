using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TangentWeb.Controllers
{
    public static class UrlHelperExtension
    {
        public static string Dashboard(this IUrlHelper helper)
        {
            return helper.RouteUrl(new { @controller = "Dashboard", @action = "Index" });
        }

        public static string PopulateCostperYearChart(this IUrlHelper helper)
        {
            return helper.RouteUrl(new { @controller = "Account", @action = "Login" });
        }


    }
}
