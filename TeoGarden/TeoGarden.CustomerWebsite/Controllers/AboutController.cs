using Microsoft.AspNetCore.Mvc;

namespace TeoGarden.CustomerWebsite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
