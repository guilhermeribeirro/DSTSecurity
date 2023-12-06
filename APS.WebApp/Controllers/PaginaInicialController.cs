using Microsoft.AspNetCore.Mvc;

namespace APS.WebApp.Controllers
{
    public class PaginaInicialController : Controller
    {
        public IActionResult PaginaInicial()
        {
            return View();
        }


        public IActionResult Especialista()
        {
            return View();
        }


        public IActionResult Doencas()
        {
            return View();
        }
    }
}
