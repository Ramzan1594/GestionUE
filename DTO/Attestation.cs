using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Attestation : IComparable 
    {
        //Propriété GET/SET pour avoir et attribué des valeurs au variables
        public int AttestationId { get; set; }
        public DateTime AttestationDate { get; set; }
        public float Point { get; set; }
        public int ObtentionNormale  { get; set; }
        public string Description { get; set; }
        public int attFkIdPersonne { get; set; }
        public int attFkIdUe { get; set; }

        //Methode pour verifier qu'un obj est bien une Attestation puis regarder si c'est la même Attestation
        public int CompareTo(object obj)
        {
            Attestation autre = null;

            if (obj is Attestation)
                autre = (Attestation)obj;
            
            return ( (this.attFkIdUe.CompareTo(autre.attFkIdUe)) );
        }


        //Constructeur
        public Attestation() { }
    }
}
