using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BL
{
    public static class Hashage
    {
        //-------------------------------------------------------------
        public static string HashageMdp(string password)
        {
            MD5 md5HashAlgo = MD5.Create();
            byte[] byteArrayToHash = Encoding.UTF8.GetBytes(password); // Place le texte dans un tableau d'octets
            byte[] hashResult = md5HashAlgo.ComputeHash(byteArrayToHash); // Hashage du texte. Le résulat est placé dans un tableau d'octets
            StringBuilder retval = new StringBuilder();
            for (int i = 0; i < hashResult.Length; i++)
            {
                retval.Append(hashResult[i].ToString("X2"));// Affichage du Hash en hexadecimal
            }
            return retval.ToString();
        }
    }
}
