using APS.Dados.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using APS.Dominio.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace APS.WebApp.Controllers
{
    public class CadastroPessoasController : Controller
    {
        private Contexto db = new Contexto();

        public IActionResult Index()
        {
            var resultado = db.CadastroPessoas
                .ToList();

            return View(resultado);
        }



        public IActionResult Inserir()
        {
            var ent = new CadastroPessoas();

            ViewBag.SexosDisponiveis = new List<SelectListItem> {
                new SelectListItem { Value = "M", Text = "Masculino" },
                new SelectListItem { Value = "F", Text = "Feminino" },
                new SelectListItem { Value = "O", Text = "Outro" },
            };

            return View(ent);
        }

        public IActionResult ConfirmarCadastro()
        {
            return View("ConfirmarCadastro");
        }

        [HttpPost]
        public IActionResult InserirConfirmar(CadastroPessoas ent)
        {
            db.CadastroPessoas.Add(ent);
            db.SaveChanges();
            return RedirectToAction("ConfirmarCadastro");
        }

        public IActionResult Excluir(int? cadastropessoasId)
        {
            if (cadastropessoasId == null)
            {
                return BadRequest(); 
            }

            var objeto = db.CadastroPessoas.FirstOrDefault(f => f.CadastroPessoasID == cadastropessoasId);

            if (objeto == null)
            {
                return NotFound();
            }

            db.CadastroPessoas.Remove(objeto);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Editar(int id)
        {
            CadastroPessoas pessoa = db.CadastroPessoas.Find(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Editar(CadastroPessoas pessoa)
        {
            if (ModelState.IsValid)
            {

                var cadastroPessoasId = HttpContext.Session.GetInt32("CadastroPessoasID");

                CadastroPessoas pessoaExistente = db.CadastroPessoas.Find(cadastroPessoasId);
                pessoaExistente.Nome = pessoa.Nome;
                pessoaExistente.Sobrenome = pessoa.Sobrenome;
                pessoaExistente.CPF = pessoa.CPF;
                pessoaExistente.Sexo = pessoa.Sexo;
                pessoaExistente.Endereco = pessoa.Endereco;
                pessoaExistente.Email = pessoa.Email;
                pessoaExistente.Senha = pessoa.Senha;

                
                db.SaveChanges();

                return RedirectToAction("Index"); 
            }

            return View(pessoa);
        }

    }
}
