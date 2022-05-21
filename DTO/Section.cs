using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //Cette classe décrit une section
    public class Section
    {
        //Propriété GET/SET pour avoir et attribué des valeurs au variables
        public int SecId { get; set; }
        public string SecCode { get; set; }
        public string SecDescription { get; set; }
        public string SecComplet
        {
            get{ return this.SecDescription; }
        }


        //Constructeur
        public Section(){}
    }
}
