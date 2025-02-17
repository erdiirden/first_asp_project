using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace deneme.Controllers
{
    public class AjaxData
    {
        public string A { get; set; }
        public string B { get; set; }
    }
    public class ProductController : Controller
    {
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult veriAl(AjaxData ajaxData)
        {
            var headers=Request.Headers.ToList();
            return View();
        }
    }
}
