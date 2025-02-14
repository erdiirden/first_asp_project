using Microsoft.AspNetCore.Mvc;

namespace aspExampleTwo.View.Product.Partials
{
    public class GetProducts : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
