using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APS.Dados.EntityFramework;
using APS.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace APS.WebApp.Controllers
{
    public class AutenticacaoController : Controller
    {
        private readonly Contexto _context;
       

        public AutenticacaoController( )
        {
            _context = new Contexto();
           
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UsuarioViewModel());
        }

        [HttpPost]
        public IActionResult Autenticar(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
               
                var usuarioBD = _context.CadastroPessoas
                    .FirstOrDefault(u => u.Email == usuario.Email && u.Senha == usuario.Senha);

                
                if (usuarioBD != null )
                {
                    HttpContext.Session.SetInt32("CadastroPessoasID", usuarioBD.CadastroPessoasID);
                    return RedirectToAction("PaginaInicial", "PaginaInicial");
                }
                else
                {

                    ModelState.AddModelError(string.Empty, "Senha inválida. Tente novamente.");
                    return RedirectToAction("CredenciaisErradas","Autenticacao");
                }
            }

            return View("Index", usuario);
        }



        public IActionResult CredenciaisErradas()
        {
            return View("CredenciaisErradas");
        }

    }
}
