using Microsoft.AspNetCore.Mvc;

namespace APS.WebApp.Controllers
{
    public class PaginaInicialController : Controller
    {
        public IActionResult PaginaInicial()
        {
            return View();
        }
    }
}
