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
            retVal.Sort();
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

        //Supprimer une session
        public static bool SupressimerSES(int sesId)
        {
            bool retVal = false;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            String requeteDelFromPAR    = "DELETE FROM PAR WHERE PAR_FK_SES = @id ";
            String requeeteDelFromSEA   = "DELETE FROM SEA WHERE SEA_FK_SES = @id ";
            String requeteDelFromSES    = "DELETE FROM SES WHERE SES_ID     = @id ";

            SqlCommand commandePAR = new SqlCommand(requeteDelFromPAR, connexion);
            commandePAR.Parameters.AddWithValue("@id", sesId);
            SqlCommand commandeSEA = new SqlCommand(requeeteDelFromSEA, connexion);
            commandeSEA.Parameters.AddWithValue("@id", sesId);
            SqlCommand commandeSES = new SqlCommand(requeteDelFromSES, connexion);
            commandeSES.Parameters.AddWithValue("@id", sesId);

            SqlTransaction transaction = null;

            try
            {
                bool okSupprimPAR = false;
                bool okSupprimSEA = false;

                int sesPAR = DAL.AccesPar.ChargerSESPAR(sesId);
                int sesSEA = DAL.AccesSeances.Charger_SEA(sesId).Count;

                connexion.Open();
                transaction = connexion.BeginTransaction();
                commandePAR.Transaction = transaction;
                commandeSEA.Transaction = transaction;
                commandeSES.Transaction = transaction;

                if(sesPAR == 0)
                    okSupprimPAR = true;
                if(sesSEA == 0)
                    okSupprimSEA = true;

                // Si la session est dans PAR 
                if (sesPAR > 0)
                {
                    if (commandePAR.ExecuteNonQuery() > 0)
                    { okSupprimPAR = true; }
                }

                // Si l'étudiant ne possède aucune attestation
                if (sesSEA > 0)
                {
                    if (commandeSEA.ExecuteNonQuery() > 0)
                    { okSupprimSEA = true; }
                }

                // Si la suppression de la session se termine avec succès alors la transaction est confirmée
                // Sinon la transaction est annulée en DB par un Rollback
                if (okSupprimPAR && okSupprimSEA)
                {
                    int count = commandeSES.ExecuteNonQuery();
                    if (count > 0)
                    {
                        transaction.Commit();
                        retVal = true;
                    }
                    else { transaction.Rollback(); }
                }
                else { transaction.Rollback(); }
            }
            catch (SqlException ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw ex;
            }
            finally
            { connexion.Close(); }
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
