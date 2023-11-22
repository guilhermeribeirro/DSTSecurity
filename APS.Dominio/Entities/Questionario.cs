using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.Entities
{
    public class Questionario
    {
        public bool TeveRelacoesSexuais { get; set; }
        public bool TeveRelacoesSemPreservativo { get; set; }
        public bool Ecasado { get; set; }
        public bool IngeriuAlcoolUltimaRelacao { get; set; }
        public bool UsouDrogasUltimaRelacao { get; set; }
        public bool TeveRelacoesParceiroFixoUltimosSeisMeses { get; set; }
    }
}
