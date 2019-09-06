using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITest.Controllers
{
    public class ProductController : Controller
    {
        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }

        }
        public IActionResult ProductName([FromQuery]string productName)
        {
            return new JsonResult(productName);
        }

        [HttpPost]
        public IActionResult ProductDetails([FromBody]Product product)
        {
            return new JsonResult(product);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}