using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITest.Controllers
{
    public class EmployeeController : Controller
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }

        }
        public IActionResult Name([FromQuery]string name)
        {
            return new JsonResult(name);
        }

        [HttpPost]
        public IActionResult EmployeeInformation([FromBody]Employee employee)
        {
            return new JsonResult(employee);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}