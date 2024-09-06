using Microsoft.AspNetCore.Mvc;

namespace C42MVC03DEMO.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ContactUS()
        {
            return View();
        }
    }
}
