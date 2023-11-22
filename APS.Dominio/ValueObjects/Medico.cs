using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.ValueObjects
{
    public class Medico
    {
       public string Urologista { get; set; }

        public string MedicoUrologista { get; set; }

        public string NomeMedico { get; set; }

        public string MedicoClinicoGeral { get; set; }

        public string MedicoEspecialidades { get; set; }

        public string CertificadoCRM { get; set; }

        public string Classificacao { get; private set; }


        public Medico(string urologista, string medicourologista, string nomemedico, string medicoclinicogeral, string medicoespecialidades, string certificadoCRM)
        {
            NomeMedico = nomemedico;

            Urologista = urologista;

            MedicoUrologista = medicourologista;


            MedicoClinicoGeral = medicoclinicogeral;

            MedicoEspecialidades = medicoespecialidades;

            CertificadoCRM = certificadoCRM;


            if (!string.IsNullOrWhiteSpace(Urologista) && !string.IsNullOrWhiteSpace(MedicoUrologista))
            {
                Classificacao = "Urologista";
            }
            else if (!string.IsNullOrWhiteSpace(MedicoClinicoGeral))
            {
                Classificacao = "Clínico Geral";
            }
            else if (!string.IsNullOrWhiteSpace(MedicoEspecialidades))
            {
                Classificacao = "Especialista em Outras Áreas";
            }
            else
            {
                Classificacao = "Não Classificado";
            }


        }




    }
}
