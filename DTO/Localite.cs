using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Localite : IComparable
    {
        //Propriété GET/SET pour avoir et attribué des valeurs au variables        
        public int LocaliteId { get; set; }
        public string LocaliteDescription { get; set; }
        public string LocaliteCodePostal { get; set; }

        //Methode pour verifier qu'un obj est bien une Localite puis trie selon le nom
        public int CompareTo(object obj)
        {
            Localite autre = null;

            if (obj is Localite)
                autre = (Localite)obj;
            return this.LocaliteDescription.CompareTo(autre.LocaliteDescription);
        }

        //Constructeur
        public Localite(){}
    }
}
