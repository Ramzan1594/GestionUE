using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //Cette classe décrit une personne
    public class Personne
    {
        //Propriété GET/SET pour avoir et attribué des valeurs au variables
        public int PersonneId { get; set; }
        public string PersonneNom { get; set; }
        public string PersonnePrenom { get; set; }
        public string PersonneSexe { get; set; }
        public DateTime PersonneDateNaissance { get; set; }
        public string PersonneRue { get; set; }
        public string PersonneNumImm { get; set; }
        public string PersonneBoîte { get; set; }
        public string PersonneLocalite { get; set; }
        public string PersonneGSM { get; set; }
        public string PersonneTel { get; set; }
        public string PersonneMail { get; set; }
        public string PersonnePwd { get; set; }
        public int PersonneAdmin { get; set; }
        public string PersonneSection { get; set; }
        public string PersonneNationalite { get; set; }
        public int PersonneidSection { get; set; }
        public int PersonneidNationalite { get; set; }
        public string PersonneCodePostal { get; set; }
        public int PersonneidLocalite { get; set; }

        //Méthode qui vérifie si deux étudiants sont identique
        public static bool sontEgaux(Personne etu1, Personne etu2)
        {
            bool retval;
            if (etu1.PersonneId == etu2.PersonneId &&
                    etu1.PersonneNom == etu2.PersonneNom &&
                    etu1.PersonnePrenom == etu2.PersonnePrenom &&
                    etu1.PersonneSexe == etu2.PersonneSexe &&
                    etu1.PersonneDateNaissance == etu2.PersonneDateNaissance &&
                    etu1.PersonneRue == etu2.PersonneRue &&
                    etu1.PersonneNumImm == etu2.PersonneNumImm &&
                    etu1.PersonneBoîte == etu2.PersonneBoîte &&
                    etu1.PersonneLocalite == etu2.PersonneLocalite &&
                    etu1.PersonneGSM == etu2.PersonneGSM &&
                    etu1.PersonneTel == etu2.PersonneTel &&
                    etu1.PersonneMail == etu2.PersonneMail &&
                    etu1.PersonnePwd == etu2.PersonnePwd &&
                    etu1.PersonneAdmin == etu2.PersonneAdmin &&
                    etu1.PersonneSection == etu2.PersonneSection &&
                    etu1.PersonneNationalite == etu2.PersonneNationalite &&
                    etu1.PersonneidSection == etu2.PersonneidSection &&
                    etu1.PersonneidNationalite == etu2.PersonneidNationalite &&
                    etu1.PersonneCodePostal == etu2.PersonneCodePostal &&
                    etu1.PersonneidLocalite == etu2.PersonneidLocalite)
            {
                retval = true;
            }
            else { retval = false; }
            return retval;
        }
        public override string ToString()
        {
            string retval =
            "id : " + this.PersonneId + "\n" +
            "nom : " + this.PersonneNom + "\n" +
            "prénom : " + this.PersonnePrenom + "\n" +
            "sexe : " + this.PersonneSexe + "\n" +
            "dateN : " + this.PersonneDateNaissance + "\n" +
            "rue : " + this.PersonneRue + "\n" +
            "num : " + this.PersonneNumImm + "\n" +
            "boite : " + this.PersonneBoîte + "\n" +
            "localite : " + this.PersonneLocalite + "\n" +
            "GSM : " + this.PersonneGSM + "\n" +
            "tel : " + this.PersonneTel + "\n" +
            "eMail : " + this.PersonneMail + "\n" +
            "PSWD : " + this.PersonnePwd + "\n" +
            "admin : " + this.PersonneAdmin + "\n" +
            "section : " + this.PersonneSection + "\n" +
            "nationalité : " + this.PersonneNationalite + "\n" +
            "section : " + this.PersonneidSection + "\n" +
            "idNat : " + this.PersonneidNationalite + "\n" +
            "code postal : " + this.PersonneCodePostal + "\n" +
            "idCp : " + this.PersonneidLocalite + "\n";
            return retval;
        }

        //Constructeur
        public Personne(){}
        //constructeur qui sauvegardera les données d'une personne pour un éventuel backup 
        public Personne(Personne autre)
        {
            this.PersonneId = autre.PersonneId;
            this.PersonneNom = autre.PersonneNom;
            this.PersonnePrenom = autre.PersonnePrenom;
            this.PersonneSexe = autre.PersonneSexe;
            this.PersonneDateNaissance = autre.PersonneDateNaissance;
            this.PersonneRue = autre.PersonneRue;
            this.PersonneNumImm = autre.PersonneNumImm;
            this.PersonneBoîte = autre.PersonneBoîte;
            this.PersonneLocalite = autre.PersonneLocalite;
            this.PersonneGSM = autre.PersonneGSM;
            this.PersonneTel = autre.PersonneTel;
            this.PersonneMail = autre.PersonneMail;
            this.PersonnePwd = autre.PersonnePwd;
            this.PersonneAdmin = autre.PersonneAdmin;
            this.PersonneSection = autre.PersonneSection;
            this.PersonneNationalite = autre.PersonneNationalite;
            this.PersonneidSection = autre.PersonneidSection;
            this.PersonneidNationalite = autre.PersonneidNationalite;
            this.PersonneCodePostal = autre.PersonneCodePostal;
            this.PersonneidLocalite = autre.PersonneidLocalite;
        }
    }
}
