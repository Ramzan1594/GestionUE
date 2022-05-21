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
    //
    public static class AccesNationalite
    {
        //*************************************************************************************************
        // Retourne la liste des nationalités
        public static List<Nationalite> ChargerNationalite()
        {
            SqlConnection connexion = Utilitaire.ObtenirConnexion();
            List<Nationalite> retVal = new List<Nationalite>();
                                    
            try
            {
                retVal = connexion.Query<Nationalite>("spChargerNationalites", commandType: CommandType.StoredProcedure).ToList();
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
    }
}
