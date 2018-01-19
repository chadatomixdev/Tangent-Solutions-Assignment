using Microsoft.AspNetCore.Mvc;

namespace TangentWeb.Controllers
{
    public class PagesController : Controller
    {
        public ActionResult PagesBlank()
        {
            return View();
        }
        public ActionResult PagesAnotherBlank()
        {
            return View();
        }
    }
}
