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
    public static class AccesPersonnes
    {
        //**************************************************************************************************
        // retourne la liste des étudiants se trouvant dans la section sélectionnée
        // la liste est triée par ordre alphabétique
        public static List<Personne> ChargerListeEtuSection(String id)
        {
            List<Personne> retVal = new List<Personne>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();
                                
            SqlCommand commande = new SqlCommand("TFEGestionUE.dbo.spChargerListeEtuSection ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", id);
                connexion.Open();
                SqlDataReader lecteur = commande.ExecuteReader();

                while (lecteur.Read() == true)
                {
                    Personne personne = new Personne();
                    personne.PersonneNom = lecteur["PPHY_NOM"].ToString();
                    personne.PersonnePrenom = lecteur["PPHY_PRN"].ToString();
                    personne.PersonneId = (int)lecteur["PPHY_ID"];
                    personne.PersonneSexe = lecteur["PPHY_SEX"].ToString();
                    personne.PersonneNationalite = lecteur["NAT_NOM"].ToString();
                    personne.PersonneDateNaissance = (DateTime)lecteur["PPHY_DTE_NAI"];
                    //personne.PersonneSection = (int)lecteur["PPHY_FK_SEC"];
                    retVal.Add(personne);
                }
                lecteur.Close();
            }
            catch (SqlException ex)
            { throw ex; }
            finally
            { connexion.Close(); }
            return retVal;
        }

        //**************************************************************************************************
        // retourne l'étudiant de la DB selon l id
        public static Personne ChargerEtudiant(int id)
        {
            Personne retVal = new Personne();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUE.dbo.spChargerPersonne", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", id);
                connexion.Open();
                SqlDataReader lecteur = commande.ExecuteReader();
                if (lecteur.Read())
                    retVal = CreerObjetPersonne(lecteur);
                lecteur.Close();
            }
            catch (SqlException ex)
            { throw ex; }
            finally
            { connexion.Close(); }
            return retVal;
        }

        //retourne l'étudiant selon le nom et prenom *************************************************************************************************
        public static List<Personne> ChargerPersonneNomPrenom(string nom, string prenom)
        {
            List<Personne> retVal = new List<Personne>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUE.dbo.spChargerPersonneNomPrenom ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@nom", nom);
                commande.Parameters.AddWithValue("@prenom", prenom);
                connexion.Open();
                SqlDataReader lecteur = commande.ExecuteReader();

                while (lecteur.Read() == true)
                {
                    Personne personne = new Personne();
                    personne.PersonneNom = lecteur["nom"].ToString();
                    personne.PersonnePrenom = lecteur["prenom"].ToString();
                    personne.PersonneId = (int)lecteur["id"];
                    personne.PersonneSexe = lecteur["sexe"].ToString();
                    personne.PersonneNationalite = lecteur["nationalite"].ToString();
                    personne.PersonneDateNaissance = (DateTime)lecteur["dateNaissance"];
                    //personne.PersonneSection = (int)lecteur["PPHY_FK_SEC"];
                    retVal.Add(personne);
                }
                lecteur.Close();
            }
            catch (SqlException ex)
            { throw ex; }
            finally
            { connexion.Close(); }
            return retVal;
        }












        //-------------------------------------------------------------
        // ajoute une personne dans PPHY, le code en récupère son id
        public static int AjouterUnePersonne(Personne etudiant)
        {
            int retVal = 0;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUE.dbo.spAjouterPersonne ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                //commande.Parameters.AddWithValue("@id", etudiant.PersonneId);
                commande.Parameters.AddWithValue("@admin", etudiant.PersonneAdmin);
                commande.Parameters.AddWithValue("@nom", etudiant.PersonneNom.Substring(0,1).ToUpper() + etudiant.PersonneNom.Substring(1).ToLower());
                commande.Parameters.AddWithValue("@prenom", etudiant.PersonnePrenom.Substring(0, 1).ToUpper() + etudiant.PersonnePrenom.Substring(1).ToLower());
                commande.Parameters.AddWithValue("@sexe", etudiant.PersonneSexe);
                commande.Parameters.AddWithValue("@dateNaissance", etudiant.PersonneDateNaissance);
                commande.Parameters.AddWithValue("@rue", etudiant.PersonneRue);
                commande.Parameters.AddWithValue("@numImm", etudiant.PersonneNumImm);
                commande.Parameters.AddWithValue("@numBoite", etudiant.PersonneBoîte);
                commande.Parameters.AddWithValue("@idLocalite", etudiant.PersonneidLocalite);
                commande.Parameters.AddWithValue("@gsm", etudiant.PersonneGSM);
                commande.Parameters.AddWithValue("@tel", etudiant.PersonneTel);
                commande.Parameters.AddWithValue("@eMail", etudiant.PersonneMail);
                commande.Parameters.AddWithValue("@pass", etudiant.PersonnePwd);
                commande.Parameters.AddWithValue("@idSection", etudiant.PersonneidSection);
                commande.Parameters.AddWithValue("@idNationalite", etudiant.PersonneidNationalite);
                connexion.Open();
                commande.ExecuteNonQuery();
                string requête = "SELECT IDENT_CURRENT('PPHY') FROM PPHY";
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
        //-------------------------------------------------------------
        public static String ModifierPersonne(Personne etuSelection)
        {
            Personne etudiant = etuSelection;
            String result;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUE.dbo.spModifierPersonne ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", etudiant.PersonneId);      // le @id  son les nom attribue dans la procedure stockee
                commande.Parameters.AddWithValue("@nom", etudiant.PersonneNom.Substring(0, 1).ToUpper() + etudiant.PersonneNom.Substring(1).ToLower());
                commande.Parameters.AddWithValue("@prenom", etudiant.PersonnePrenom.Substring(0, 1).ToUpper() + etudiant.PersonnePrenom.Substring(1).ToLower());
                commande.Parameters.AddWithValue("@sexe", etudiant.PersonneSexe);
                commande.Parameters.AddWithValue("@dateNaissance", etudiant.PersonneDateNaissance);
                commande.Parameters.AddWithValue("@rue", etudiant.PersonneRue);
                commande.Parameters.AddWithValue("@numImm", etudiant.PersonneNumImm);
                commande.Parameters.AddWithValue("@numBoite", etudiant.PersonneBoîte);
                commande.Parameters.AddWithValue("@idLocalite", etudiant.PersonneidLocalite);
                commande.Parameters.AddWithValue("@gsm", etudiant.PersonneGSM);
                commande.Parameters.AddWithValue("@tel", etudiant.PersonneTel);
                commande.Parameters.AddWithValue("@eMail", etudiant.PersonneMail);
                commande.Parameters.AddWithValue("@idSection", etudiant.PersonneidSection);
                commande.Parameters.AddWithValue("@idNationalite", etudiant.PersonneidNationalite);
                connexion.Open();
                int count = commande.ExecuteNonQuery();
                if (count > 0) { result = "Modification réussie"; }
                else { result = "échec de la modification !"; }
                return result;
            }
            catch (SqlException ex)
            {
                result = ex.Message;
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return result;
            }
        }




        //**************************************************************************************************
        // Supprime un etudadiant en supprimant les entrées des tables ATT et PAR liées à des contraintes 
        // Utilisation des transactions pour annuler la suppression et conserver les données en cas d'échèc
        public static Boolean SupressionEtudiant(int sId)
        {
            bool retVal = false;
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            String requêteDelFromPAR = "DELETE FROM PAR WHERE PAR_FK_PPHY = @id ";
            String requêteDelFromATT = "DELETE FROM ATT WHERE ATT_FK_PPHY = @id ";
            String requêteDelFromPPHY= "DELETE FROM PPHY WHERE PPHY_ID  = @id ";

            SqlCommand commandePAR = new SqlCommand(requêteDelFromPAR, connexion);
            commandePAR.Parameters.AddWithValue("@id", sId);
            SqlCommand commandeATT = new SqlCommand(requêteDelFromATT, connexion);
            commandeATT.Parameters.AddWithValue("@id", sId);
            SqlCommand commandePPHY = new SqlCommand(requêteDelFromPPHY, connexion);
            commandePPHY.Parameters.AddWithValue("@id", sId);
            SqlTransaction transaction = null;

            try
            {
                bool okSupprimAtt;
                bool okSupprimSes;
                int attPossedees = AccesAttestations.AttPossedees(sId);
                int inscritASession = AccesSessions.EstInscritASession(sId);

                connexion.Open();
                transaction = connexion.BeginTransaction();
                commandePAR.Transaction = transaction;
                commandeATT.Transaction = transaction;
                commandePPHY.Transaction = transaction;

                // Si l'étudiant ne participe à aucune session 
                // ou SI la suppression en DB des sessions auxquelles il participe se termine avec succès
                // Alors la suppression de l'étudiant est autorisée
                // Sinon la suppression est refusée
                if (inscritASession > 0)
                {
                    if (commandePAR.ExecuteNonQuery() > 0)
                    { okSupprimSes = true; }
                    else
                    { okSupprimSes = false; }
                }
                else { okSupprimSes = true; }

                // Si l'étudiant ne possède aucune attestation
                // ou SI la suppression en DB des attestations possédées par l'étudiant se termine avec succès
                // Alors la suppression de l'étudiant est autorisée
                // Sinon la suppression est refusée
                if (attPossedees > 0)
                {
                    if (commandeATT.ExecuteNonQuery() > 0)
                    { okSupprimAtt = true; }
                    else
                    { okSupprimAtt = false; }
                }
                else { okSupprimAtt = true; }

                // Si la suppression de l'étudiant se termine avec succès alors la transaction est confirmée
                // Sinon la transaction est annulée en DB par un Rollback
                if (okSupprimAtt && okSupprimSes)
                {
                    int count = commandePPHY.ExecuteNonQuery();
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
















        //****************************************************************************************************************************************************************************************************
        //****************************************************************************************************************************************************************************************************
        //Méthode qui est utilisé dans la méthode ChargerEtudiant pour cree l'étudiant pour la UC_DISP_ETU
        static private Personne CreerObjetPersonne(SqlDataReader lecteur)
        {
            Personne retVal = new Personne();
            retVal.PersonneId = (int)lecteur["id"];
            retVal.PersonneNom = lecteur["nom"].ToString();
            retVal.PersonnePrenom = lecteur["prenom"].ToString();
            retVal.PersonneSexe = lecteur["sexe"].ToString();

            String str = lecteur["dateNaissance"].ToString();

            //------PersonneDateNaissance est un DateTime
            //DateTime dt = DateTime.ParseExact(str, "dd-MM-yy HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime dt = Convert.ToDateTime(str);

            //------PersonneDateNaissance est un String
            //retVal.PersonneDateNaissance = dt.ToString("dd/MM/yyyy");
            //retVal.PersonneDateNaissance = lecteur["dateNaissance"];

            retVal.PersonneDateNaissance = dt;

            retVal.PersonneRue = lecteur["rue"].ToString();
            retVal.PersonneNumImm = lecteur["numImm"].ToString();
            retVal.PersonneBoîte = lecteur["numBoite"].ToString();
            retVal.PersonneGSM = lecteur["gsm"].ToString();
            retVal.PersonneTel = lecteur["telephone"].ToString();
            retVal.PersonneMail = lecteur["eMail"].ToString();
            retVal.PersonnePwd = lecteur["pass"].ToString();
            retVal.PersonneAdmin = ((bool)lecteur["adm"] == true ? 1 : 0);
            retVal.PersonneNationalite = lecteur["nationalite"].ToString();
            retVal.PersonneLocalite = lecteur["localite"].ToString();
            retVal.PersonneSection = lecteur["section"].ToString();
            retVal.PersonneCodePostal = lecteur["codePostal"].ToString();
            retVal.PersonneidNationalite = (int)lecteur["id_nat"];
            retVal.PersonneidSection = (int)lecteur["id_sec"];
            retVal.PersonneidLocalite = (int)lecteur["id_loc"];

            return retVal;
        }
    }
}
