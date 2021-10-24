using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomicStabilityProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 3, 5, 7, 9 };
            Solution solution = new Solution();

            int result = solution.solution(input);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int prevInterval = 0;
            int interval = 0;
            int stabilityCount = 0;
            int iterationCount = 0;
            int temp = 0;
            int temp2 = 0;
            int length = A.Length;

            if (length > 2)
            {
                prevInterval = A[1] - A[0];
                for (int i = 1; i < length; i++)
                {
                    if (i + 1 < length)
                    {
                        interval = A[i + 1] - A[i];
                        if (prevInterval == interval)
                        {
                            iterationCount++;
                        }
                        else
                        {
                            if (iterationCount > 0)
                            {
                                iterationCount += 1;
                                temp2 = (2 * Factorial(iterationCount - 2));

                                if (temp2 > 0)
                                {
                                    temp = (Factorial(iterationCount)) / temp2;
                                }

                                stabilityCount += temp;
                            }

                            iterationCount = 0;
                        }
                        prevInterval = interval;
                    }
                    else
                    {
                        if (iterationCount > 0)
                        {
                            iterationCount += 1;
                            temp2 = (2 * Factorial(iterationCount - 2));

                            if (temp2 > 0)
                            {
                                temp = (Factorial(iterationCount)) / temp2;
                            }

                            stabilityCount += temp;
                        }
                    }

                }
            }

            return stabilityCount;
        }

        public static int Factorial(int value)
        {
            int result = 1;

            if(value > 0)
            {
                for (int i = value; i > 0; i--)
                {
                    result *= i;
                }
            }          

            return result;
        }
    }
}
