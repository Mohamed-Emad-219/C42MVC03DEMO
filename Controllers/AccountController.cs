using Microsoft.AspNetCore.Mvc;

namespace C42MVC03DEMO.Controllers
{
    public class AccountController : Controller 
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
