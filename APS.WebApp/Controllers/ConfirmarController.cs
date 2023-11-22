using Microsoft.AspNetCore.Mvc;

namespace APS.WebApp.Controllers
{
    public class ConfirmarController : Controller
    {
        public IActionResult ConfirmarCadastro()
        {
            return View();
        }
    }
}
