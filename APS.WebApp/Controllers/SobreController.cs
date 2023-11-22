using Microsoft.AspNetCore.Mvc;

namespace APS.WebApp.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Sobre()
        {
            return View();
        }
    }
}
