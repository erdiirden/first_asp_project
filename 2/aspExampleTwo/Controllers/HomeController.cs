using Microsoft.AspNetCore.Mvc;

namespace aspExampleTwo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
