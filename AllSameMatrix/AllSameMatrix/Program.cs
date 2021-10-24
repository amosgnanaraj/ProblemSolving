using System;

namespace AllSameMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (int.TryParse(Console.ReadLine(), out int dimension))
                {
                    if (dimension % 2 == 1)
                    {
                        int[,] matrix = new int[dimension, dimension];
                        int total = dimension * dimension;
                        int start = (dimension - 1) / 2;
                        int x = start, y = 0;
                        matrix[x, y] = 1;
                        string result = string.Empty;

                        for (int i = 1; i < total; i++)
                        {
                            y--;
                            x++;

                            if(y<0 && x < dimension && x >= 0 && matrix[x, dimension - 1] == 0)
                            {
                                y = dimension - 1;
                                matrix[x, y] = i + 1;
                            }
                            else if(x>dimension-1 && y<dimension && y>=0 && matrix[0,y]==0)
                            {
                                x = 0;
                                matrix[x, y] = i + 1;
                            }
                            else if(x<dimension && x>=0 && y < dimension && y >= 0 && matrix[x,y]==0)
                            {
                                matrix[x, y] = i + 1;
                            }
                            else
                            {
                                x--;
                                y += 2;
                                matrix[x, y] = i + 1;
                            }
                        }

                        for (int i = 0; i < dimension; i++)
                        {
                            for (int j = 0; j < dimension; j++)
                            {
                                Console.Write($"|{matrix[j, i]}");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only odd number allowed");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }

            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
        }
    }
}
