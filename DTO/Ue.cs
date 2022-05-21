using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //Cette classe décrit une UE
    public class Ue : IComparable
    {
        //Propriété GET/SET pour avoir et attribué des valeurs au variables
        public int UeId { get; set; }
        public string Intitule { get; set; }
        public Boolean Determinante { get; set; }
        public int Periode { get; set; }
        public Decimal Prctg { get; set; }
        public DateTime DateDeReussite { get; set; }
        //Situation sera le Prcentage + la date de reussite
        public string Situation { get; set; }
        public DateTime SessDeb { get; set; }
        public DateTime SessFin { get; set; }
        public int SES_ID { get; set; }
        public bool EPI { get; set; }


        //Methode pour verifier qu'un obj est bien une UE puis regarder si c'est la même UE
        public int CompareTo(object obj)
        {
            Ue autre = null;

            if (obj is Ue)
                autre = (Ue)obj;
            return this.Intitule.CompareTo(autre.Intitule);
        }


        //Constructeur
        public Ue() {}

    }
}
