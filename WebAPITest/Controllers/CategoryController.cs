using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITest.Controllers
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
    public class CategoryController : Controller
    {
       
        public IActionResult CategoryName(string categoryName)
        {
            return new JsonResult(categoryName);
        }

        [HttpPost]
        public IActionResult Details([FromBody]Category category)
        {
            return new JsonResult(category);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}