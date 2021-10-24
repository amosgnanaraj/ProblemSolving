using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            int L = 0;
            int R = 0;
            string temp = string.Empty;
            bool isNotPrime = false;
            List<int> prime = new List<int>();

            for (int i = 0; i < T; i++)
            {
                temp = Console.ReadLine();
                L = Convert.ToInt32(temp.Split(' ')[0]);
                R = Convert.ToInt32(temp.Split(' ')[1]);

                for (int j = L; j <= R; j++)
                {
                    for (int k = 2; k < j; k++)
                    {
                        if (j % k == 0)
                        {
                            isNotPrime = true;
                            break;
                        }
                        else
                        {
                        }
                    }
                    if (!isNotPrime)
                    {
                        prime.Add(j);
                    }
                    isNotPrime = false;
                }
                if (prime.Count() > 1)
                {
                    Console.WriteLine($"{prime.LastOrDefault() - prime.FirstOrDefault()}");
                }
                else if (prime.Count() == 1)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("-1");
                }
                prime = new List<int>();
            }

            Console.ReadLine();
        }
    }
}
