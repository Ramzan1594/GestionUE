using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //Classe qui décrit une nationalité
    public class Nationalite
    {
        //Propriété GET/SET pour avoir et attribué des valeurs au variables
        public int NAT_ID { get; set; }
        public string NAT_NOM { get; set; }

        //Constucteur
        public Nationalite() { }
    }
}
