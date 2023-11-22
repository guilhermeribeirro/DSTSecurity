using APS.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace APS.Dominio.ValueObjects
{
    public class DoencasSexualmenteTransmissiveis
    {

        public string Aids { get; set; }

        public string Sifilis { get; set; }

        public string Hiv { get; set; }

        public string HerpesGenital { get; set; }

        public string Gonorreia { get; set; }   


        public DoencasSexualmenteTransmissiveis(string aids, string sifilis, string hiv, string herpesgenital, string gonorreia)
        {

            Aids = aids;
            Sifilis = sifilis;      
            Hiv = hiv;  
            HerpesGenital = herpesgenital;
            Gonorreia = gonorreia;

        }
     

    }
}
