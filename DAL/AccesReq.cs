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
    public class AccesReq
    {
        //_________________________________________________________________________________
        // Charger la liste des prerequis pour les UE d'une section
        public static List<Requis> Charger_Req(int secId)
        {
            List<Requis> retVal = new List<Requis>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUe.dbo.spChargerRequis ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                commande.Parameters.AddWithValue("@id", secId);
                connexion.Open();
                var lecteur = commande.ExecuteReader();
                while (lecteur.Read())
                {
                    Requis ligne = new Requis();
                    ligne.REQ_FK_PRE_UE = (int)lecteur["REQ_FK_PRE_UE"];
                    ligne.REQ_FK_SUI_UE = (int)lecteur["REQ_FK_SUI_UE"];
                    retVal.Add(ligne);
                }
                lecteur.Close();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { connexion.Close(); }
            return retVal;
        }
    }
}
