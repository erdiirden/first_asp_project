using firstAspProejct.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstAspProejct.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts() //view dosyası da aynı isimde olmalı (GetProducts)
        {
            //--ŞUAN CONTROLLER DAYIZ--

            //--VERİ ALINACAKSA MODELE GİDİYORUZ VE ALIYORUZ--
            Products products = new Products(); //model a gidip veri alma

            //--TASARIM ALINACAKSA VİEW A GİDİYORUZ VE ALIYORUZ--
            return View(); //response (default olarak aynı isimdeki view i çağırır(getproducts)


            // return View("ali"); //manuel olarak (ali) view çağırma
        }
        
    }
}
