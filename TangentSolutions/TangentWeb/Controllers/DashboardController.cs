using Microsoft.AspNetCore.Mvc;

namespace TangentWeb.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
