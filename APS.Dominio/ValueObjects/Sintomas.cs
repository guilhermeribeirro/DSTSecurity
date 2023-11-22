using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.ValueObjects
{
    public class Sintomas
    {
       
            public string CorrimentoEsbranquicadoAcinzentado { get; set; }
            public bool CoceiraRegiaoGenital { get; set; }
            public bool DorAoUrinar { get; set; }
            public bool VerrugasGenitais { get; set; }
            public bool FeridasOuAftasRegiaoGenital { get; set; }
            public bool CheiroForteRegiaoGenital { get; set; }
            public bool Febre { get; set; }
            public bool GargalosNoPescoco { get; set; }
            public bool TosseDorDeGarganta { get; set; }

            public Sintomas(string corrimento, bool coceira, bool dorAoUrinar, bool verrugas, bool feridasAftas, bool cheiroForte, bool febre, bool gargalos, bool tosseDorGarganta)
            {
                CorrimentoEsbranquicadoAcinzentado = corrimento;
                CoceiraRegiaoGenital = coceira;
                DorAoUrinar = dorAoUrinar;
                VerrugasGenitais = verrugas;
                FeridasOuAftasRegiaoGenital = feridasAftas;
                CheiroForteRegiaoGenital = cheiroForte;
                Febre = febre;
                GargalosNoPescoco = gargalos;
                TosseDorDeGarganta = tosseDorGarganta;
            }
        



    }
}
