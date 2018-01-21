using Microsoft.AspNetCore.Mvc;

namespace TangentWeb.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PopulateEmployeesTable()
        {



            return null;

            //var json = _databaseService.ListOrders()
            //    .Select(o => new
            //    {
            //        OrderID = o.OrderId,
            //        Customer = o.Customer.Company,
            //        Product = o.Product.Name,
            //        o.Quantity,
            //        o.OrderDateTime
            //    });

            //return Json(new { data = json }, new JsonSerializerSettings() { ContractResolver = new DefaultContractResolver() });
        }
    }
}
