using Microsoft.AspNetCore.Mvc;

namespace SmarTaxiWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Management");
            }

            return View();
            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Tu pagina de contacto, escribe";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
