using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.ValueObjects
{
    
        public class Questionario
        {
            public bool TeveRelacoesSexuais { get; set; }
            public bool TeveRelacoesSexuaisSemPreservativo { get; set; }
            public bool Ecasado { get; set; }
            public bool IngeriuAlcoolNaUltimaRelacaoSexual { get; set; }
            public bool UsouDrogasNaUltimaRelacaoSexual { get; set; }
            public bool TeveParceiroFixoNosUltimosSeisMeses { get; set; }

            public Questionario(bool teveRelacoes, bool semPreservativo, bool casado, bool ingeriuAlcool, bool usouDrogas, bool parceiroFixo)
            {
                TeveRelacoesSexuais = teveRelacoes;

                TeveRelacoesSexuaisSemPreservativo = semPreservativo;

                Ecasado = casado;

                IngeriuAlcoolNaUltimaRelacaoSexual = ingeriuAlcool;

                UsouDrogasNaUltimaRelacaoSexual = usouDrogas;

                TeveParceiroFixoNosUltimosSeisMeses = parceiroFixo;
            }
        }




    
}
