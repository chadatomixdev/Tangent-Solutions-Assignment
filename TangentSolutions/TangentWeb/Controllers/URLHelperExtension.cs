using Microsoft.AspNetCore.Mvc;

namespace TangentWeb.Controllers
{
    public static class UrlHelperExtension
    {
        public static string Dashboard(this IUrlHelper helper)
        {
            return helper.RouteUrl(new { @controller = "Dashboard", @action = "Index" });
        }

        public static string PopulateEmployeesTable(this IUrlHelper helper)
        {
            return helper.RouteUrl(new { @controller = "Employees", @action = "PopulateEmployeesTable" });
        }
    }
}
