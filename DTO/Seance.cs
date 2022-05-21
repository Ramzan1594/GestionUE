using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //Cette classe décrit une Séance
    public class Seance : IComparable
    {
        //Propriété GET/SET pour avoir et attribué des valeurs au variables
        public int SeaId { get; set; }
        public string Intitule { get; set; }
        public DateTime SeaDateDeb { get; set; }
        public DateTime SeaDateFin { get; set; }
        public string SeaJour { get; set; }
        public string SeaCreneau { get; set; }
        public int seaFKSes { get; set; }

        //Methode pour verifier qu'un obj est bien une Session puis regarder si c est la meme session
        public int CompareTo(object obj)
        {
            Seance other = null;  

            if (obj is Seance)
                other = (Seance)obj;
            //return  this.SesId.CompareTo(other.SesId);

            DateTime currentSeance = this.SeaDateDeb;
            DateTime otherSeance = other.SeaDateDeb;

            return currentSeance.CompareTo(otherSeance);   //sinon trie sur la date

        }

        //Constructeur
        public Seance() { }
    }
}
