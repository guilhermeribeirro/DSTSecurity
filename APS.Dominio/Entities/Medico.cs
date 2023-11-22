using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.Entities
{
    public class Medico
    {

        public int MedicoID { get; set; }
        public bool Urologista { get; set; }
        public bool ClinicoGeral { get; set; }
        public string Especialidades { get; set; }
        public string NomeMedico { get; set; }
        public string CRM { get; set; }
    }
}













