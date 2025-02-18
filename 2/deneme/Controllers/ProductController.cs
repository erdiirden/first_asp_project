using deneme.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

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
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            //doğrulamaları (validations) if else switch ile if(model.length<100) gibi yapma 
            //ModelState: MVC'de bir type ın data annotationslarının durumunu kontrol eden ve geriye sonuç döndüren property

            if (!ModelState.IsValid) {

                var messages = ModelState.ToList();
                return View(model);
            }
            //işleme/operasyona/algoritmaya tabi tutulur.
            return View();
        }

    }
}
