using System;
using System.Linq;
using System.Text;

namespace VowelRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            foreach (var item in value)
            {
                if(!vowels.Contains(item))
                {
                    sb.Append(item);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
