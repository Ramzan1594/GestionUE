using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC
{
    public static class ExceptionHandler
    {
        public static class ExceptionHandlers
        {
            private static Dictionary<string, string> DicoException;

            static ExceptionHandlers()
            {
                ExceptionHandlers.DicoException = new Dictionary<string, string>();

                ExceptionHandlers.DicoException.Add("Key", "Value");

                // Erreurs Hors DB
                ExceptionHandlers.DicoException.Add("La référence d'objet n'est pas définie", "Veuillez faire une sélection !");
                ExceptionHandlers.DicoException.Add("PPHY_SES_ATT",
                    "Attention l'étudiant est inscrit à une session en cour " +
                    "ou possède une attestation de réussite vieille de moins de 5 ans. \n"
                    + "Etes vous dur de vouloir le supprimer ?");

                // DB ATT----- Attestation
                ExceptionHandlers.DicoException.Add("ATT_FK_PPHY", "Suppression de l'attestation refusée : elle est liée à un ou plusieurs étudiants qui la possède");
                ExceptionHandlers.DicoException.Add("ATT_FK_UE", "Suppression de l'attestation refusée : une ou plusieurs UE lui sont liées");
                // DB PAR----- Participe
                ExceptionHandlers.DicoException.Add("PAR_FK_SES", "Inscription refusée, avez vous choisit une session ?");
                ExceptionHandlers.DicoException.Add("PAR_FK_PPHY", "Inscritption refusée, avez-vous bien sélectionné un étudiant ?");
                // DB PPHY----- Personne
                ExceptionHandlers.DicoException.Add("PPHY_FK_LOC", "Inscription de l'étudiant refusée, veuillez encoder une adresse complète !");
                ExceptionHandlers.DicoException.Add("PPHY_FK_SEC", "Inscription de l'étudiant refusée, le choix d'une section est impératif !");
                ExceptionHandlers.DicoException.Add("PPHY_FK_NAT", "Inscription de l'étudiant refusée, veuillez encoder une nationalité valide !");
                // DB REQ----- Requis
                ExceptionHandlers.DicoException.Add("REQ_FK_PRE_UE", "Erreur détectée sur les prérequis, veuillez prévenir le service informatique");
                ExceptionHandlers.DicoException.Add("REQ_FK_SUI_UE", "Erreur détectée sur les prérequis, veuillez prévenir le service informatique");
                // DB SEA----- Séance
                ExceptionHandlers.DicoException.Add("SEA_FK_SES", "Une séances doit faire partie d'une session, veuillez en sélectionneer une !");
                // DB SES----- Session
                ExceptionHandlers.DicoException.Add("SES_FK_UE", "Une session fait partie d'une UE, veuillez sélectionner une UE avant d'encoder une session !");
                // DB UE----- Unité d'enseugnemant
                ExceptionHandlers.DicoException.Add("UE_FK_SEC", "Une UE doit appartenir à une section, veuillez sélectionner une section avant de poursuivre l'encodage des UE !");
            }
            //-------------------------------------------------------------
            // Interprete les exceptions sur base du message
            // Si une correspondance est trouvée : renvoie le message compréhensible correspondant
            // Sinon informe l'utilisateur que l'exception n'est pas prise en charge
            public static string TraduireEnClair(string message)
            {
                string retval = "Execption Handler ne prend pas en charge cette erreur.";

                foreach (string key in ExceptionHandlers.DicoException.Keys)
                    if (message.Contains(key))
                        retval = ExceptionHandlers.DicoException[key];

                return retval;

                //Exemple d'utilisation dans UC_DISP_ETU : 
                // string message = EXC.ExceptionHandler.ExceptionHandlers.TraduireEnClair("PPHY_SES_ATT");
                // DialogResult dialogResult = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo);
            }

            //-------------------------------------------------------------
            // Interprete les exceptions sur base de l'exception elle même
            // Si une correspondance est trouvée : renvoie le message compréhensible correspondant
            // Sinon informe l'utilisateur que l'exception n'est pas prise en charge
            //       et renvoie le message initial de l'exxception
            public static string TraduireEnClair(Exception ex)
            {
                Exception exception = ex;
                string message = exception.Message;
                string retval = "Execption Handler ne prend pas en charge cette erreur.";
                int count = 0;

                foreach (string key in ExceptionHandlers.DicoException.Keys)
                {
                    if (message.Contains(key))
                    {
                        retval = ExceptionHandlers.DicoException[key];
                        count++;
                    }
                }
                if (count == 0) // si l'erreur est inconnue returne le message d'erreur initial
                {
                    retval += " ; " + exception.Message + " ; " + exception.GetType().ToString();
                }
                else { }

                return retval;

                // Exemple d'utilisation dans UC_CRUP_ETU :

                // catch (Exception ex)
                // {
                //      string exMsg = EXC.ExceptionHandler.ExceptionHandlers.TraduireEnClair(ex);
                //      MessageBox.Show(exMsg);
                // }

                // remplace :

                // catch (Exception ex)
                // {
                //      MessageBox.Show(ex.Message, ex.GetType().ToString());
                // }

            }
        }
    }
}
