using System;
using System.Security.Cryptography;
using System.Text;

namespace VF.Store.UI.Infraestrutura
{
    public static class Helpers
    {
        public static string Encrypt(this string senha)
        {
            var salt = "|2791AE66C83742EBAEC5513A13C5F0AF45A796D55403467ABB84149C18E3DA1B";

            var arraybytes = Encoding.UTF8.GetBytes(senha + salt);

            byte[] hashBytes;

            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arraybytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}
