using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.Entities
{
    public class CadastroPessoas
    {


        public int CadastroPessoasID { get; set; }  
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public char Sexo { get; set; }
       
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}


