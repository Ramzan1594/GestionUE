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
    public class AccesAttestations
    {
        //-------------------------------------------------------------
        // ajoute une attestation dans ATT, le code en récupère son id
        public static int AjouterAttestation(Attestation att)
        {
            int retVal = 0;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUE.dbo.spAjouterAttestation ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                //commande.Parameters.AddWithValue("@id", etudiant.PersonneId);
                commande.Parameters.AddWithValue("@dateObtention", att.AttestationDate);
                commande.Parameters.AddWithValue("@point", att.Point);
                commande.Parameters.AddWithValue("@obtentionNormale", att.ObtentionNormale);
                commande.Parameters.AddWithValue("@description", att.Description);
                commande.Parameters.AddWithValue("@idPersonne", att.attFkIdPersonne);
                commande.Parameters.AddWithValue("@idUe", att.attFkIdUe);

                connexion.Open();
                commande.ExecuteNonQuery();
                string requête = "SELECT IDENT_CURRENT('ATT') FROM ATT";
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



        //Méthode qui retourne la liste des UE pour lequelles l'étudiant a une ATTESTATION
        public static List<Ue> Charger_UE_ATT(int etuId)
        {
            List<Ue> retVal = new List<Ue>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerUeAttestation", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", etuId);
                connexion.Open();
                SqlDataReader lecteur = commande.ExecuteReader();

                while (lecteur.Read())
                {
                    Ue ue = new Ue();                    
                    ue.UeId = (int)lecteur["UE_ID"];
                    ue.Intitule = lecteur["UE_NOM"].ToString();
                    ue.Determinante = (bool)lecteur["UE_DET"];
                    ue.Periode = (int)lecteur["UE_NBR_PER"];
                    ue.Prctg = Convert.ToDecimal(lecteur["ATT_PTS"]);
                    ue.DateDeReussite = (DateTime)lecteur["ATT_DTE"];
                    ue.Situation = ue.Prctg + "% obtenue le : " + ue.DateDeReussite.ToShortDateString();

                    retVal.Add(ue);
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

        //**************************************************************************************************
        // permet de déterminer si l'étudiant possède des attestations vielles de moins de 5 ans.
        // retourne le nombre d'attestations.
        public static int AttDeMoinsDe5AnsPossedees(int etuId)
        {
            int retVal = 0;
            int id = etuId;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spAttestationMoins5ans", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", id);
                connexion.Open();

                SqlDataReader lecteur = commande.ExecuteReader();

                if (lecteur.Read() == true)
                { retVal = (int)lecteur[0]; }
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
        // permet de déterminer si l'étudiant possède une attestation pour une UE specifique.
        // retourne l'attestation.
        public static int AttPossedeesPourUe(int etuId, int ueId)
        {
            int retVal = 0;
            int id = etuId;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spAttPossedeesPourUe", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@idPersonne", etuId);
                commande.Parameters.AddWithValue("@idUe", ueId);

                connexion.Open();

                SqlDataReader lecteur = commande.ExecuteReader();

                if (lecteur.Read() == true)
                { retVal = (int)lecteur[0]; }
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
        // permet de déterminer si l'étudiant possède des attestations.
        // retourne le nombre d'attestations.
        public static int AttPossedees(int etuId)
        {
            int retVal = 0;
            int id = etuId;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spAttPossedees", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@idPersonne", id);

                connexion.Open();

                SqlDataReader lecteur = commande.ExecuteReader();

                if (lecteur.Read() == true)
                { retVal = (int)lecteur[0]; }
                lecteur.Close();
            }
            catch (SqlException)
            {
                return retVal;
            }
            connexion.Close();
            return retVal;
        }
    }
}
