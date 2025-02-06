using firstAspProejct.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstAspProejct.Controllers
{
    public class ProductController : Controller
    {
        #region Example 1
        //public IActionResult GetProducts() //view dosyası da aynı isimde olmalı (GetProducts)
        //{
        //    //--ŞUAN CONTROLLER DAYIZ--

        //    //--VERİ ALINACAKSA MODELE GİDİYORUZ VE ALIYORUZ--
        //    Products products = new Products(); //model a gidip veri alma

        //    //--TASARIM ALINACAKSA VİEW A GİDİYORUZ VE ALIYORUZ--
        //    return View(); //response (default olarak aynı isimdeki view i çağırır(getproducts)


        //    // return View("ali"); //manuel olarak (ali) view çağırma
        //}
        #endregion

        #region ViewResult
        //public ViewResult GetProducts()
        //{
        //    ViewResult result = View();
        //    return result;
        //}
        #endregion

        #region PartialViewResult
        //ajax teknolojisini kullanıyorsak kullanırız.
        //public PartialViewResult GetProducts()
        //{
        //    PartialViewResult result = PartialView();
        //    return result;
        //}
        #endregion

        #region JsonResult
        //public JsonResult GetProducts()
        //{
        //    JsonResult result = Json(new Products
        //    {
        //        Id = 1,
        //        ProductName = "terlik",
        //        Quantity = 15,
        //    });
        //    return result;
        //}
        #endregion

        #region EmptyResult
        //boş response atar
        //public EmptyResult GetProducts()
        //{
        //    return new EmptyResult();
        //}
        #endregion

        #region ContentResult
        //istek neticesinde metinsel değer döndürmek için, html değil metin belgesi döner
        //public ContentResult GetProducts()
        //{
        //    ContentResult result = Content("Anla beni gidecek yolum yok");
        //    return result;
        //}
        
        #endregion

        #region ActionResult
        //public ActionResult GetProducts()
        //{
        //    if (true)
        //    {
        //        return Json(new object());
        //    }
        //    else if (true)
        //    {
        //        return Content("dkjdfksdjf");
        //    }
        //    return View();
        //}
        #endregion

        #region IActionResult
        //public IActionResult GetProducts()
        //{
        //    return View();
        //}
        #endregion
    }
}
