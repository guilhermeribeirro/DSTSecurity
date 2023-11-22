using Microsoft.AspNetCore.Mvc;

namespace APS.WebApp.Controllers
{
    public class MissaoController : Controller
    {
        public IActionResult Missao()
        {
            return View();
        }
    }
}
