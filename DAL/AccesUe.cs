using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using BO;


namespace DAL
{
    public class AccesUe
    {
        // Méthode qui charge la listes des ue d'une section
        public static List<Ue> Charger_UE(int secId)
        {
            List<Ue> retVal = new List<Ue>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerUe", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", secId);
                connexion.Open();
                SqlDataReader lecteur = commande.ExecuteReader();

                while(lecteur.Read())
                {
                    Ue ue = new Ue();
                    ue.UeId         = (int)lecteur["UE_ID"];
                    ue.Intitule     = lecteur["UE_NOM"].ToString();
                    ue.Determinante = (bool)lecteur["UE_DET"];
                    ue.Periode      = (int)lecteur["UE_NBR_PER"];
                    ue.EPI          = (bool)lecteur["UE_EPI"];
                    ue.Situation    = "Restante";

                    retVal.Add(ue);
                }
                lecteur.Close();
            }
            catch(Exception ex)
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

        //-------------------------------------------------------------
        // Ajouter une entrée dans PAR pour inscrire un étudiant à une session
        public static void InscrireALaSession(Personne etu, int sesId)
        {
            Personne etudiant = etu;
            int idPersonne = etudiant.PersonneId;
            int idSession = sesId;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spInscrireEtuSession ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@idSes", idSession);
                commande.Parameters.AddWithValue("@idPersonne", idPersonne);
                commande.Parameters.AddWithValue("@dateInscription", DateTime.Today);

                connexion.Open();
                commande.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connexion.Close();
            }
        }

        // Retire la ligne dans PAR pour desinscrire l'etudiant a une UE
        public static int DesinscrireDuneUe(Personne etu, int sesId)
        {
            int ret = 0;

            Personne etudiant = etu;
            int idPersonne = etudiant.PersonneId;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            string reqDelFromPAR = "DELETE FROM PAR WHERE PAR_FK_SES = @sesId AND PAR_FK_PPHY = @idPersonne";
            SqlCommand commande = new SqlCommand(reqDelFromPAR, connexion);

            try
            {
                commande.Parameters.AddWithValue("@sesId", sesId);
                commande.Parameters.AddWithValue("@idPersonne", idPersonne);

                connexion.Open();
                ret = commande.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connexion.Close();
            }
            return ret;
        }
    }
}
