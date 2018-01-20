using Microsoft.AspNetCore.Mvc;
using TangentWeb.Helpers;
using TangentWeb.Models;

namespace TangentWeb.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                AuthenticationHelper.Authenticate(model.Username, model.Password, AuthenticationResult);

            }

            return View();
        }

        private void AuthenticationResult(bool isValid)
        {
            if (isValid)
            {
                RedirectToAction("Index", "Dashboard");
            }
        }
    }
}
