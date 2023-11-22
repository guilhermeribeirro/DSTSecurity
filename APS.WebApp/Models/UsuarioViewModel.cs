using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APS.WebApp.Models
{
    public class UsuarioViewModel
    {
        public string Email { get; set; }


        public string Senha { get; set; }   


        public bool ManterConectado { get; set; }   


        public bool Autenticado()

        {
            if (Email == "renato" && Senha == "123")
                 return true;

            else
                return false;   
               
        }


    }
}
