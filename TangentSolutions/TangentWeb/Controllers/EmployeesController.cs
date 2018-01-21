using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TangentWeb.Helpers;
using TangentWeb.Models;

namespace TangentWeb.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PopulateEmployeesTable()
        {
            var url = WebRequestHelper.BaseUrl + "api/employee/";

            var token = HttpContext.Session.GetObjectFromJson<Token>("token");
            var response = await WebRequestHelper.MakeAsyncRequest(url, token.token);
            var data = response.Content.ReadAsStringAsync().Result;

            var employeesObject = JsonConvert.DeserializeObject<List<Employee>>(data);

            var employees = employeesObject.Select(e => new
            {
                Id = e.User.id,
                FirstName = e.User.first_name,
                LastName = e.User.last_name,
                Email = e.email,
                PhoneNumber = e.phone_number,
                Gender = e.gender,
                Race = e.race,
                YearsWorked = e.years_worked,
                Age = e.age
            });

            return Json(new { data = employees }, new JsonSerializerSettings() { ContractResolver = new DefaultContractResolver() });
        }
    }
}
