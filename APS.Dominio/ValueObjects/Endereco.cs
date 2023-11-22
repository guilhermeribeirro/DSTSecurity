using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.ValueObjects
{
    public class Endereco
    {

        public string Rua { get; set; }

        public string Cidade { get; set; }  


        public string CEP { get; set; } 

        public int Numero { get; set; } 

        public string Complemento { get; set; }


        public Endereco(string rua, string cidade, string cep, int numero, string complemento)
        {

            Rua = rua;
            Cidade = cidade;    
            CEP = cep;
            Numero = numero;
            Complemento = complemento;
                
        }

        public string EnderecoInserido()
        {
            return $"Endereço: {Rua} , {Numero} , {Cidade}";
        }

        public override string ToString()
        {
            return EnderecoInserido();
        }



    }
}
