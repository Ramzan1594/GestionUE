using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UC
{
    public static class Validateur
    {
        private static string titreDéfaut = "Erreur d'encodage";
        public static string TitreDéfaut
        {
            get { return Validateur.titreDéfaut; }
            set { Validateur.titreDéfaut = value; }
        }
        public static string EstRempli(Control controle)
        {
            string retVal = "";
            if ((controle.GetType().ToString() == "System.Windows.Forms.TextBox"     && (controle).Text == "") 
                || (controle.GetType().ToString() == "System.Windows.Forms.ComboBox" && ((ComboBox)controle).SelectedIndex == -1))
            {
                //MessageBox.Show("Erreur ! La zone \"" + controle.Tag.ToString() +
                //"\" est obligatoire.",
                //TitreDéfaut, MessageBoxButtons.OK, MessageBoxIcon.Error);
                controle.Focus();
                retVal = "Vérifier à ce que toutes les cases soient remplies.\n\n";
            }
            return retVal;
        }
        public static string EstUnDecimal(TextBox textBox)
        {
            string retVal = "";
            try
            {
                decimal nbr = Convert.ToDecimal(textBox.Text);
                if (nbr < 50 || nbr > 100)
                    throw new FormatException();
            }
            catch (FormatException)
            {
                //MessageBox.Show("Erreur ! La zone \"" + textBox.Tag.ToString() +
                //"\" doit contenir une valeur décimale.",
                //TitreDéfaut, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                retVal = "Le résultat doit comprendre un nombre entre 50 et 100 inclus (50% requis pour une réussite).\n";
            }
            return retVal;
        }
        public static string EstUnEntier(TextBox textBox)
        {
            string retVal = "";
            try
            {
                Convert.ToInt32(textBox.Text);
            }
            catch (FormatException)
            {
                //MessageBox.Show("Erreur ! La zone \"" + textBox.Tag.ToString() +
                //"\" doit contenir une valeur entière",
                //TitreDéfaut, MessageBoxButtons.OK, MessageBoxIcon.Error);
                retVal = "Le numéro d'immeuble doit être un entier. \n";
                textBox.Focus();
            }
            return retVal;
        }
        public static string EstunMail(TextBox textBox)
        {
            string retVal = "";
            if (Regex.Match(textBox.Text, @"\w*@\w*[.]\w").Success == false)
            {
                //MessageBox.Show("Erreur ! La zone \"" + textBox.Tag.ToString() +
                //"\" doit contenir une adresse Mail valide", TitreDéfaut);
                textBox.Focus();
                retVal = "Le mail doit avoir le format : exemple@mail.ex.\n"; 
            }
            return retVal;
        }
        public static bool EstUnCodePostal(TextBox textBox, int minCp, int maxCp)
        {
            bool retVal = true;
            int cp = Convert.ToInt32(textBox.Text);
            if (cp <= minCp || cp >= maxCp)
            {
                //MessageBox.Show("Erreur ! La zone " + textBox.Tag.ToString() +
                //" doit contenir une valeur comprise entre " + minCp +
                //" et " + maxCp + ".", TitreDéfaut);
                textBox.Focus();
                retVal = false;
            }
            return retVal;
        }
        public static string EstUnNumeroDeTelephone(TextBox textBox)
        {
            string retVal = "";
            string phoneChars = textBox.Text.Replace(".", "");

            if (Regex.Match(phoneChars, @"0[0-9]{9}").Success == false)
            {
                //MessageBox.Show("Erreur ! La zone \"" + textBox.Tag.ToString() +
                //"\" doit contenir une adresse Mail valide", TitreDéfaut);
                textBox.Focus();
                retVal = "Les numéros de téléphone doivent débuter par un 0 suivi de neuf chiffres.\n";
            }

            return retVal;
        }

        public static string EstUnedateDeNaissance(DateTimePicker dat)
        {
            string ret = "";

            if(DateTime.Now < dat.Value || dat.Value.AddYears(15) > DateTime.Now)
            {
                ret = "La date n'est pas acceptable. L'âge de l'étudiant ne peut être inférieur à 15 ans.\n";
            }

            return ret;
        }

        public static string EstUneDateAttestation(DateTimePicker dat)
        {
            string ret = "";
            string a = dat.Value.AddYears(15).ToString();
            if (dat.Value.AddYears(5) < DateTime.Now)
            {
                ret = "La date n'est pas acceptable. L'attestation doit avoir moins de 5 ans pour être valable.\n";
            }

            return ret;
        }

        public static string EstAssezLong(TextBox text, int longueur)
        {
            string ret = "";

            if (text.TextLength < longueur)
            {
                ret = "Les cases Nom/Prénom doivent compter au moins deux caractères.\n";
            }
                
            return ret;
        }
    }
}
