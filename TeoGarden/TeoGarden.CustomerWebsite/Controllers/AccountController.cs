using Microsoft.AspNetCore.Mvc;

namespace TeoGarden.CustomerWebsite.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View("index", null);
        }
    }
}
