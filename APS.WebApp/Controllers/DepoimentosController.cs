using APS.Dados.EntityFramework;
using APS.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APS.WebApp.Controllers
{
    public class DepoimentosController : Controller
    {
        private Contexto db = new Contexto();

        public IActionResult Index()
        {
            var resultado = db.Depoimentos
                .ToList();

            return View(resultado);
        }


        public IActionResult Inserir()
        {
            var ent = new Depoimentos();
            return View(ent);
        }

        [HttpPost]
        public IActionResult InserirConfirmar(Depoimentos ent)
        {
            db.Depoimentos.Add(ent);
            db.SaveChanges();
            return RedirectToAction("ConfirmarDepoimento");
        }



        public IActionResult ConfirmarDepoimento()
        {
            return View("ConfirmarDepoimento");
        }

    }
}
