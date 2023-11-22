using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.ValueObjects
{
    public class Laudo
    {
        public string AtestadoMedicoAoCliente { get; set; }

        public string LaudoMedico{ get; set; }

        public string ReceitaMedicaDoMedico { get; set; }


        public Laudo(string atestadomedicocliente, string laudomedico, string receitamedicadomedico)

        {
            AtestadoMedicoAoCliente = atestadomedicocliente;

            LaudoMedico = laudomedico;

            ReceitaMedicaDoMedico = receitamedicadomedico;



        }


       




    }
}
