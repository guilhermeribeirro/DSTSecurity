using APS.Dados.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using APS.Dominio.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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

            ViewBag.SexosDisponiveis = new List<SelectListItem> {
                new SelectListItem { Value = "M", Text = "Masculino" },
                new SelectListItem { Value = "F", Text = "Feminino" },
                new SelectListItem { Value = "O", Text = "Outro" },
            };

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
