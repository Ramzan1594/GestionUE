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
    public class AccesSessions
    {
        //__________________________________________________________________________________________
        //Charger toutes les sessions d'une section
        public static List<Session> Charger_SES(int secId)
        {
            List<Session> retVal = new List<Session>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerSessions ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", secId);
                connexion.Open();

                var lecteur = commande.ExecuteReader();

                while (lecteur.Read())
                {
                    Session ligne = new Session();

                    ligne.SesId     = (int)lecteur["SES_ID"]; 
                    ligne.SesDeb    = Convert.ToDateTime(lecteur["SES_DTE_DEB"]);
                    ligne.SesFin    = Convert.ToDateTime(lecteur["SES_DTE_FIN"]);
                    ligne.Intitule  = lecteur["UE_NOM"].ToString();
                    
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
            //retVal.Sort();
            return retVal;
        }


        //Ajouter une session 
        public static int AjouterSession(Session ses)
        {
            int retVal = 0;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUE.dbo.spAjouterSession ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                //commande.Parameters.AddWithValue("@id", etudiant.PersonneId);
                commande.Parameters.AddWithValue("@sesDateDeb", ses.SesDeb);
                commande.Parameters.AddWithValue("@sesDateFin", ses.SesFin);
                commande.Parameters.AddWithValue("@sesFkUe", ses.SesFkUe);

                connexion.Open();
                commande.ExecuteNonQuery();
                string requête = "SELECT IDENT_CURRENT('SES') FROM SES";
                commande = new SqlCommand(requête, connexion);
                retVal = Convert.ToInt32(commande.ExecuteScalar());
            }

            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connexion.Close();
            }
            return retVal;
        }


        //Charge toutes les sessions enregistree d'une ue
        public static List<Session> Charger_SESDuneUe(int ueId)
        {
            List<Session> retVal = new List<Session>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerSessionsDuneUe ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@ueId", ueId);
                connexion.Open();

                var lecteur = commande.ExecuteReader();

                while (lecteur.Read())
                {
                    Session ligne = new Session();

                    ligne.SesId = (int)lecteur["SES_ID"];
                    ligne.SesDeb = Convert.ToDateTime(lecteur["SES_DTE_DEB"]);
                    ligne.SesFin = Convert.ToDateTime(lecteur["SES_DTE_FIN"]);
                    ligne.Intitule = lecteur["UE_NOM"].ToString();

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
            //retVal.Sort();
            return retVal;
        }



































        //-------------------------------------------------------------
        // retourne le nombre de sessions en cour auxquelles un étudiant est inscrit
        public static int EstInscritASessionEnCour(int etuId)
        {
            int id = etuId;
            int retVal = 0;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spEtuInscriSessEnCour ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", id);
                connexion.Open();

                SqlDataReader lecteur = commande.ExecuteReader();

                if (lecteur.Read() == true)
                {
                    retVal = (int)lecteur[0];
                }
                lecteur.Close();
            }
            catch (SqlException)
            {
                return retVal;
            }
            connexion.Close();
            return retVal;
        }

        //**************************************************************************************************
        // retourne le nombre de sessions auxquelles un étudiant est inscrit
        public static int EstInscritASession(int etuId)
        {
            int id = etuId;
            int retVal = 0;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spEstInscritASession ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", id);
                connexion.Open();

                SqlDataReader lecteur = commande.ExecuteReader();

                if (lecteur.Read() == true)
                {
                    retVal = (int)lecteur[0];
                }
                lecteur.Close();
            }
            catch (SqlException)
            {
                return retVal;
            }
            connexion.Close();
            return retVal;
        }


        // charge une liste de UE selon d'une section qui ont une session
        public static List<Ue> Charger_UEavecSES(int secId)
        {
            List<Ue> retVal = new List<Ue>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerSessions ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", secId);
                connexion.Open();

                var lecteur = commande.ExecuteReader();

                while (lecteur.Read())
                {
                    Ue ligne = new Ue();
                    ligne.UeId = (int)lecteur["UE_ID"];
                    ligne.Intitule = lecteur["UE_NOM"].ToString();
                    //ligne.Periode = (int)lecteur["UE_NBR_PER"];
                    //ligne.Determinante = (bool)lecteur["UE_DET"];
                    //ligne.Situation = "programmé";
                    ligne.SessDeb = Convert.ToDateTime(lecteur["SES_DTE_DEB"]);
                    ligne.SessFin = Convert.ToDateTime(lecteur["SES_DTE_FIN"]);
                    ligne.SES_ID = (int)lecteur["SES_ID"];
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
    }
}
