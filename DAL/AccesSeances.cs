using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AccesSeances
    {
        //charge la listes des seances d'une section
        public static List<Seance> Charger_SEASEC(int secId)
        {
            List<Seance> retVal = new List<Seance>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            string req = "SELECT * "
                        + "FROM SEA s "
                        + "JOIN SES ss ON s.SEA_FK_SES = ss.SES_ID "
                        + "JOIN UE u ON ss.SES_FK_UE = u.UE_ID "
                        + "JOIN SEC sc ON u.UE_FK_SEC = sc.SEC_ID "
                        + "WHERE sc.SEC_ID = @secId ";

            SqlCommand commande = new SqlCommand(req, connexion);

            try
            {
                commande.Parameters.AddWithValue("@secId", secId);
                connexion.Open();

                var lecteur = commande.ExecuteReader();

                while (lecteur.Read())
                {
                    Seance ligne = new Seance();

                    ligne.SeaId = (int)lecteur["SEA_ID"];
                    ligne.SeaDateDeb = Convert.ToDateTime(lecteur["SEA_DTE_DEB"]);
                    ligne.SeaDateFin = Convert.ToDateTime(lecteur["SEA_DTE_FIN"]);
                    ligne.SeaJour = lecteur["SEA_JOUR"].ToString();
                    ligne.SeaCreneau = lecteur["SEA_CRE"].ToString();
                    ligne.seaFKSes = (int)lecteur["SEA_FK_SES"];
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


        //charger les seance d'une session
        public static List<Seance> Charger_SEA(int sesId)
        {
            List<Seance> retVal = new List<Seance>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerSeances ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@idSES", sesId);
                connexion.Open();

                var lecteur = commande.ExecuteReader();

                while (lecteur.Read())
                {
                    Seance ligne = new Seance();

                    ligne.SeaId     = (int)lecteur["SEA_ID"];
                    ligne.SeaDateDeb= Convert.ToDateTime(lecteur["SEA_DTE_DEB"]);
                    ligne.SeaDateFin= Convert.ToDateTime(lecteur["SEA_DTE_FIN"]);
                    ligne.SeaJour   = lecteur["SEA_JOUR"].ToString();
                    ligne.SeaCreneau= lecteur["SEA_CRE"].ToString();
                    ligne.seaFKSes  = (int)lecteur["SEA_FK_SES"];
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



        //__________________________________________________________________________________________
        //Charger tous les UE qui ont une session qui arrive ( dont la date de fin n'est pas passee)
        public static List<Ue> Charger_UESEA(int sesId)
        {
            List<Ue> retVal = new List<Ue>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerSeances ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@idSES", sesId);
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


        //Ajouter une seance 
        public static int AjouterSeance(Seance sea)
        {
            int retVal = 0;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUE.dbo.spAjouterSeances", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            

            try
            {
                commande.Parameters.AddWithValue("@seaDateDeb", sea.SeaDateDeb);
                commande.Parameters.AddWithValue("@seaDateFin", sea.SeaDateFin);
                commande.Parameters.AddWithValue("@seaJour", sea.SeaJour);
                commande.Parameters.AddWithValue("@seaCreneau", sea.SeaCreneau);
                commande.Parameters.AddWithValue("@seaFkSes", sea.seaFKSes);

                connexion.Open();
                commande.ExecuteNonQuery();
                string requête = "SELECT IDENT_CURRENT('SEA') FROM SEA ";
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




        //**************************************************************************************************
        // Supprime une seance 
        // Utilisation des transactions pour annuler la suppression et conserver les données en cas d'échèc
        public static int SupressimerSEA(int seaId)
        {
            int retVal= 0;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();


            string requeteDelFromSEA = "DELETE FROM SEA WHERE SEA_ID = @seaId ";
            SqlCommand commandeSEA = new SqlCommand(requeteDelFromSEA, connexion);
            
            try
            {
                commandeSEA.Parameters.AddWithValue("@seaId", seaId);
                connexion.Open();
                retVal = commandeSEA.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {                
                throw ex;
            }
            finally
            { connexion.Close(); }
            return retVal;
        }

    }
}
