using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Servicios
{
    public class Encriptador
    {
        public static string Hash_md5(string value)
        {
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(Encoding.ASCII.GetBytes(value));
            return BitConverter.ToString(md5data).Replace("-", "").ToLower();
        }

        public static string HashHex(string input)
        {
            byte[] data = Encoding.UTF8.GetBytes(input ?? string.Empty);
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(data);
                StringBuilder sb = new StringBuilder(hash.Length * 2);
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}