using Microsoft.AspNetCore.Mvc;

namespace firstAspProejct.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Page()
        {
            return View();
        }

        public IActionResult Page2()
        {
            return View();
        }

        public IActionResult Page3()
        {
            return View();
        }
    }
}
