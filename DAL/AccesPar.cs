using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using BO;


namespace DAL
{
    public class AccesPar
    {
        //UE dans lequel l'etudiant est inscrit
        public static List<Ue> Charger_UE_INS(int etuId)
        {
            List<Ue> retVal = new List<Ue>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spUeEnCourEtuParticipe ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", etuId);
                connexion.Open();
                var lecteur = commande.ExecuteReader();
                while (lecteur.Read())
                {
                    Ue ligne = new Ue();
                    ligne.SES_ID = (int)lecteur["SES_ID"];
                    ligne.UeId = (int)lecteur["UE_ID"];
                    ligne.Intitule = lecteur["UE_NOM"].ToString();
                    ligne.Periode = (int)lecteur["UE_NBR_PER"];
                    ligne.Determinante = (bool)lecteur["UE_DET"];
                    ligne.Situation = "En Cours";
                    ligne.SessDeb = Convert.ToDateTime(lecteur["SES_DTE_DEB"]);
                    ligne.SessFin = Convert.ToDateTime(lecteur["SES_DTE_FIN"]);

                    retVal.Add(ligne);
                }
                lecteur.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connexion.Close();
            }
            retVal.Sort();
            return retVal;
        }



        // retourne le nombre de ligne dans PAR ou il y a une session specifique
        public static int ChargerSESPAR(int sesId)
        {
            int retVal = 0;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            string requeteDelFromPAR = "SELECT COUNT(*) FROM PAR WHERE PAR_FK_SES = @sesId ";
            SqlCommand commandePAR = new SqlCommand(requeteDelFromPAR, connexion);

            try
            {
                commandePAR.Parameters.AddWithValue("@sesId", sesId);
                connexion.Open();
                retVal = Convert.ToInt32(commandePAR.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connexion.Close();
            }
            return retVal;
        }
    }
}
