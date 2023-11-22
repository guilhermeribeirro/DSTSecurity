using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.Entities
{
    public class Usuario
    {
        public string Nome { get; set; }    

        public string Sobrenome { get; set; }   
        public int Id { get; set; }
        
        public string Endereco { get; set; }

        public string Complemento { get; set; } 


        public int Idade { get; set; }

        public bool Genero { get; set; }    


        public string DataNascimento { get; set; }  





    }
}
