using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_crud_webapi.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            ViewData["title"] = "Home";
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewData["title"] = "Dettaglio Pizza";
            return View(id);
        }

        public IActionResult Message(int id)
        {
            ViewData["title"] = "Contattaci";
            return View();
        }
    }
}
