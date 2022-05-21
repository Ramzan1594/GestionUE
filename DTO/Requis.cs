using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //Cette classe décrit les lien de "pré-requis" entre UE
    public class Requis
    {
        //Propriété GET/SET pour avoir et attribué des valeurs au variables
        public int REQ_FK_PRE_UE { get; set; }
        public int REQ_FK_SUI_UE { get; set; }

        //Constructeur
        public Requis() { }
    }
}
