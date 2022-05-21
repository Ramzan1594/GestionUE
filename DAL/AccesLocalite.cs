using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DTO;
using Dapper;

namespace DAL
{
    public static class AccesLocalite
    {
        //-------------------------------------------------------------
        // retourne la liste des localités
        public static List<Localite> ChargerLocalites()
        {
            List<Localite> retVal = new List<Localite>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerLocalites", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try

            {
                connexion.Open();
                SqlDataReader lecteur = commande.ExecuteReader();
                while (lecteur.Read() == true)
                {
                    Localite localite = new Localite();
                    localite.LocaliteId = Convert.ToInt32(lecteur["LOC_ID"]);
                    localite.LocaliteDescription = lecteur["LOC_DES"].ToString();
                    localite.LocaliteCodePostal = lecteur["LOC_CP"].ToString();
                    retVal.Add(localite);
                }
                lecteur.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connexion.Close(); }
            retVal.Sort();
            return retVal;
        }
        //-------------------------------------------------------------
        // rafraichit le textBox localité quand un nouveau code postal est sélectionné
        // retourne la localité correspondant au code postal
        public static Localite ChargerDescriptionLocalite(string cp)
        {
            string codePostal = cp;
            Localite retVal = new Localite();
            
;            SqlConnection connexion = Utilitaire.ObtenirConnexion();
            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerDescriptionCp ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@cp", codePostal);
                connexion.Open();
                SqlDataReader lecteur = commande.ExecuteReader();
                if (lecteur.Read() == true)
                {
                    retVal.LocaliteId = Convert.ToInt32(lecteur["LOC_ID"]);
                    retVal.LocaliteDescription = lecteur["LOC_DES"].ToString();
                    retVal.LocaliteCodePostal = lecteur["LOC_CP"].ToString();
                }
                lecteur.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connexion.Close(); }
            return retVal;
        }
        //-------------------------------------------------------------
        // rafraichit le textBox code postal quand une localité est sélectionnée
        // retourne le code postal correspondant 
        public static Localite ChargerCp(string localite)
        {
            string loc = localite;
            Localite retVal = new Localite();

            ; SqlConnection connexion = Utilitaire.ObtenirConnexion();
            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerCp ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@localite", loc);
                connexion.Open();
                SqlDataReader lecteur = commande.ExecuteReader();
                if (lecteur.Read() == true)
                {
                    retVal.LocaliteId = Convert.ToInt32(lecteur["LOC_ID"]);
                    retVal.LocaliteDescription = lecteur["LOC_DES"].ToString();
                    retVal.LocaliteCodePostal = lecteur["LOC_CP"].ToString();
                }
                lecteur.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connexion.Close(); }
            return retVal;
        }




        //-------------------------------------------------------------
        // Alimente le texyBox avec la localaité correspondant au code postal de l'étudiant sélectionné
        public static Localite ChargerLocaliteTb(int etuId)
        {
            int id = etuId;
            Localite retVal = new Localite();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerLocalite ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", id);
                connexion.Open();
                SqlDataReader lecteur = commande.ExecuteReader();
                if (lecteur.Read() == true)
                {
                    retVal.LocaliteId = Convert.ToInt32(lecteur["LOC_ID"]);
                    retVal.LocaliteDescription = lecteur["LOC_DES"].ToString();
                    retVal.LocaliteCodePostal = lecteur["LOC_CP"].ToString();
                }
                lecteur.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { connexion.Close(); }
            return retVal;
        }
    }
}
