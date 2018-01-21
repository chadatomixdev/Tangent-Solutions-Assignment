using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TangentWeb.Helpers;
using TangentWeb.Models;

namespace TangentWeb.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var data = await AuthenticationHelper.Authenticate(model.Username, model.Password);

            if (data.AuthenticationStatus != AuthenticationStatus.Succeeded) return View();

            HttpContext.Session.SetObjectAsJson("token",data.Data);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
