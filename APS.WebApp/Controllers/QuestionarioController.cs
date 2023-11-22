using Microsoft.AspNetCore.Mvc;

namespace APS.WebApp.Controllers
{
    public class QuestionarioController : Controller
    {
        public IActionResult Questionario()
        {
            return View();
        }
    }
}
