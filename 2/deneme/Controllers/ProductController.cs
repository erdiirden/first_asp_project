using deneme.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace deneme.Controllers
{  
    public class ProductController : Controller
    {
        public IActionResult GetProduct()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            var tuple = (new Product(), new User());
            return View(tuple);
        }
        [HttpPost]
        public IActionResult CreateProduct([Bind(Prefix ="Item1")]Product product, [Bind(Prefix = "Item2")] User user)
        {
            return View();
        }

    }
}
