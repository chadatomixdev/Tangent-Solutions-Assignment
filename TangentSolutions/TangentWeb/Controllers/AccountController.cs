using Microsoft.AspNetCore.Mvc;

namespace TangentWeb.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
