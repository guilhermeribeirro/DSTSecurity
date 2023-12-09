using APS.Dados.EntityFramework;
using APS.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APS.WebApp.Controllers
{
    public class CadastroMedicosController : Controller
    {
        private Contexto db = new Contexto();

        public IActionResult Index()
        {
            var resultado = db.CadastroMedicos
                .ToList();

            return View(resultado);
        }


        public IActionResult Inserir()
        {
            var ent = new CadastroMedicos();
            return View(ent);
        }

        [HttpPost]
        public IActionResult InserirConfirmar(CadastroMedicos ent)
        {
            db.CadastroMedicos.Add(ent);
            db.SaveChanges();
            return RedirectToAction("ConfirmarCadastro");
        }



        public IActionResult ConfirmarCadastro()
        {
            return View("ConfirmarCadastro");
        }
    }
}
