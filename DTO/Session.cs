using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //Cette classe décrit une session
    public class Session : IComparable
    {
        //Propriété GET/SET pour avoir et attribué des valeurs au variables
        public int SesId { get; set; }
        public string Intitule { get; set; }
        public DateTime SesDeb { get; set; }
        public DateTime SesFin { get; set; }
        public int SesFkUe { get; set; }

        //Methode pour verifier qu'un obj est bien une Session puis regarder si c est la meme session
        public int CompareTo(object obj)
        {
            Session other = null;  

            if (obj is Session)
                other = (Session)obj;
            //return  this.SesId.CompareTo(other.SesId);

            DateTime currentSession = this.SesDeb;
            DateTime otherSession = other.SesDeb;

            return currentSession.CompareTo(otherSession);   //sinon trie sur la date

        }

        //Constructeur
        public Session() {}
    }
}
