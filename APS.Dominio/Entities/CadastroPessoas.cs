using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.Entities
{
    public class CadastroPessoas
    {


        public int CadastroPessoasID { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public char Sexo { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string Senha { get; set; }

    }
}


