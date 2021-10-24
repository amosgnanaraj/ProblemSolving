using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptString
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = decryptPassword("Pa");

            Console.WriteLine(result);


        }

        public static string decryptPassword(string s)
        {
            //51Pa*0Lp*0e
            //aP1pL5e
            Stack<char> chars = new Stack<char>();
            string decryptedPassword = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]) && s[i] != '0')
                {
                    //temp[tempPtr++] = s[i];
                    chars.Push(s[i]);
                }
                else if (char.IsDigit(s[i]))
                {
                    decryptedPassword += chars.Pop();
                }
                else if (char.IsUpper(s[i]) && s.Length > i && char.IsLower(s[i + 1]))
                {
                    decryptedPassword += $"{s[i + 1]}{s[i]}";
                    i++;
                }
                else if (char.IsLetter(s[i]))
                {
                    decryptedPassword += s[i];
                }
            }

            return decryptedPassword;
        }
    }
}
