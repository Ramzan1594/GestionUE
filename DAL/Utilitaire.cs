using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public static class Utilitaire
    {
        //Lien vers la DB de la machine
        public static SqlConnection ObtenirConnexion()
        {
            return new SqlConnection(
                @"Data Source=RAMZAN-NOXCHO\SQLEXPRESS;
                Initial Catalog=TFEGestionUE;
                Integrated Security=True;
                Connect Timeout=30;
                Encrypt=False;
                TrustServerCertificate=True;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False");
        }
    }
}
