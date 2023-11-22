using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.ValueObjects
{
    public class Usuario
    {

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public int Idade { get; set; }

        public bool Genero { get; set; }

        public string DataNascimento { get; set; }  

        public Usuario(string nome, string sobrenome, int idade, bool genero,string datanascimento) 
        
        { 


            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Genero = genero;
            DataNascimento = datanascimento;


        
        }



    }
}
