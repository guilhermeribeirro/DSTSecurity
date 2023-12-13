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


        public IActionResult ConfirmarExclusao()
        {
            return View("ConfirmarExclusao");
        }

        public IActionResult EditarCadastroConfirmado()
        {
            return View("EditarCadastroConfirmado");
        }



        [HttpPost]
        public IActionResult InserirConfirmar(CadastroPessoas ent)
        {
            db.CadastroPessoas.Add(ent);
            db.SaveChanges();
            return RedirectToAction("ConfirmarCadastro");
        }

        public IActionResult Excluir()
        {
            if (HttpContext.Session.GetInt32("CadastroPessoasID") is int id && id > 0)
            {
                var pessoaParaExcluir = db.CadastroPessoas.Find(id);

                if (pessoaParaExcluir != null)
                {
                    db.CadastroPessoas.Remove(pessoaParaExcluir);
                    db.SaveChanges();
                }

                // Limpa a session após a exclusão
                HttpContext.Session.Remove("CadastroPessoasID");
            }

            return RedirectToAction("ConfirmarExclusao");
        }



        public ActionResult Editar()
        {
            if (HttpContext.Session.GetInt32("CadastroPessoasID") is int codigo && codigo > 0)
            {
                CadastroPessoas pessoa = db.CadastroPessoas.Find(codigo);

                if (pessoa != null)
                {
                    return View(pessoa);
                }
            }

            return NotFound();
        }

        public IActionResult Missao()
        {
            var numeroRegistros = db.CadastroPessoas.Count();
            ViewBag.NumeroRegistros = numeroRegistros;
            return View();
        }




        [HttpPost]
      
        [ValidateAntiForgeryToken]
        public ActionResult Editar(CadastroPessoas pessoa)
        {
            if (ModelState.IsValid)
            {
                var cadastroPessoasId = HttpContext.Session.GetInt32("CadastroPessoasID");

                CadastroPessoas pessoaExistente = db.CadastroPessoas.Find(cadastroPessoasId);

                if (pessoaExistente != null)
                {
                    pessoaExistente.Nome = pessoa.Nome;
                    pessoaExistente.Sobrenome = pessoa.Sobrenome;
                    pessoaExistente.CPF = pessoa.CPF;
                    pessoaExistente.Sexo = pessoa.Sexo;
                    pessoaExistente.Endereco = pessoa.Endereco;
                    pessoaExistente.Email = pessoa.Email;
                    pessoaExistente.Senha = pessoa.Senha;

                    db.SaveChanges();

                    return RedirectToAction("EditarCadastroConfirmado");
                }
                else
                {
                    ModelState.AddModelError("", "Pessoa não encontrada");
                }
            }

            // Se o ModelState não estiver válido ou a pessoa não for encontrada, redisplay o formulário com erros
            return View(pessoa);
        }

    }




}
