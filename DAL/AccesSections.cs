using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using BO;

namespace DAL
{
    public class AccesSections
    {
        // retourne la liste des sections
        public static List<Section> ChargerSection()
        {
            List<Section> retVal = new List<Section>();
            SqlConnection connexion = Utilitaire.ObtenirConnexion();

            SqlCommand commande = new SqlCommand("TFEGestionUE.dbo.spChargerSection ", connexion);
            commande.CommandType = CommandType.StoredProcedure;

            try
            {
                connexion.Open();
                SqlDataReader lecteur = commande.ExecuteReader();
                while (lecteur.Read() == true)
                {
                    Section section = new Section();
                    section.SecId = Convert.ToInt32(lecteur["SEC_ID"]);
                    section.SecCode = lecteur["SEC_CDE"].ToString();
                    section.SecDescription = lecteur["SEC_DES"].ToString();
                    retVal.Add(section);
                }
                lecteur.Close();
            }
            catch (SqlException ex)
            { throw ex; }
            finally
            { connexion.Close(); }
            return retVal;
        }
    }
}
