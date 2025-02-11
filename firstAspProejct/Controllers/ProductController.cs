using firstAspProejct.Models;
using firstAspProejct.Models.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Text.Json;

namespace firstAspProejct.Controllers
{
    public class ProductController : Controller
    {
        //public IActionResult Index()
        //{
        //    var products=new List<Products>
        //    {
        //        new Products{Id=1, ProductName="A Product", Quantity=10},
        //        new Products{Id=2, ProductName="B Product", Quantity=15},
        //        new Products{Id=3, ProductName="C Product", Quantity=20}
        //    };
        //    #region Model Bazlı Veri Gönderimi
        //    //return View(products);
        //    #endregion

        //    #region ViewBag
        //    //View'e gönderilecek/taşınacak datayı dinamik şekilde tanımlayan bir değişkenle taşımamızı sağlayan veri taşıma kontrolü
        //    //ViewBag.products = products;
        //    #endregion

        //    #region ViewData
        //    //ViewBag'de olduğu gibi actiondaki datayı view'e taşımamızı sağlayan kontroldür (dinamik değil) unboxing
        //    //ViewData["products"]=products;
        //    #endregion

        //    #region TempData
        //    //ViewData'de olduğu gibi actiondaki datayı view'e taşımamızı sağlayan kontroldür (dinamik değil) unboxing
        //    string data = JsonSerializer.Serialize(products);
        //    TempData["products"] = data;
        //    #endregion

        //    //TempData["x"] = 5;
        //    //ViewBag.x = 5;
        //    //ViewData["x"] = 5;

        //    return RedirectToAction("Index2", "Product");
        //}

        //public IActionResult Index2()
        //{
        //    //var v1=ViewBag.x;
        //    //var v2=ViewData["x"];
        //    //var v3 = TempData["x"];

        //    var data = TempData["products"].ToString();
        //    List<Products> products = JsonSerializer.Deserialize<List<Products>>(data);
        //    return View();
        //}


        // İlk ders ve action türleri
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

        public IActionResult GetProducts()
        {
            Product product = new Product
            {
                Id = 1,
                ProductName = "a producyt",
                Quantity = 15
            };

            User user = new User()
            {
                Id = 1,
                Name="Erdi",
                LastName="İrden"
            };

            //UserProcuct userProcuct = new UserProcuct
            //{
            //    User = user,
            //    Product = product
            //};
            //return View(userProcuct);




            var userProduct = (product, user);
            return View(userProduct);
        }
    }
}
