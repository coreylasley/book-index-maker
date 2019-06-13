using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace BookIndexMaker
{
    public class Common
    {
        public static string GetCode(string input)
        {
            string s = input.ToUpper().Trim();
            int sum = 0;
            string res = "";
            string nres = "";
            foreach (byte b in System.Text.Encoding.UTF8.GetBytes(s.ToCharArray()))
            {
                int v = Convert.ToInt32(b.ToString());
                sum += v;
                res += v.ToString();
            }
            for (int x = 0; x < s.Length; x++)
            {
                res = GetVersionNumber(res + sum.ToString()).ToUpper().Replace("O", "1").Replace("0", "A");
            }
            for (int x = 0; x < 25; x++)
            {
                nres += res.Substring(x, 1);
                if (x == 4 || x == 9 || x == 14 || x == 19) nres += "-";
            }

            return nres.ToString();
        }

        public static string GetVersionNumber(string pass)
        {
            int i;
            MD5 ANDFFDDSSS = MD5CryptoServiceProvider.Create();
            byte[] MJUIO = ANDFFDDSSS.ComputeHash(Encoding.Default.GetBytes(pass));
            StringBuilder sb = new StringBuilder();
            for (i = 0; i < MJUIO.Length; i++)
            {
                sb.AppendFormat("{0:x2}", MJUIO[i]);
            }

            return sb.ToString();
        }
    }
}
