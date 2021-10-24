using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesMan
{
    class Program
    {
        static void Main(String[] args)
        {
            //Write code here
            int T = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < T; j++)
            {
                string NandP = Console.ReadLine();
                int N = Convert.ToInt32(NandP.Split(' ')[0]);
                int P = Convert.ToInt32(NandP.Split(' ')[1]);
                List<int> visitedNodes = new List<int>();
                string tempData = string.Empty;
                int result = 0;
                PositionByCost[] PositionByCost = new PositionByCost[P];


                for (int i = 0; i < P; i++)
                {
                    tempData = Console.ReadLine();
                    PositionByCost[i] = new PositionByCost
                    {
                        X = Convert.ToInt32(tempData.Split(' ')[0]),
                        Y = Convert.ToInt32(tempData.Split(' ')[1]),
                        C = Convert.ToInt32(tempData.Split(' ')[2])
                    };
                }

                PositionByCost maxVal = PositionByCost.Where(x => x.C == PositionByCost.Max(y => y.C)).FirstOrDefault();

                result += maxVal.C;

                int fromNode = maxVal.X;
                int toNode = maxVal.Y;
                int currentMax = maxVal.C;

                visitedNodes.Add(fromNode);
                visitedNodes.Add(fromNode);
                List<PositionByCost> byCosts = new List<PositionByCost>();

                while (visitedNodes.Count() < N)
                {
                    byCosts = PositionByCost.Where(x => (x.X == fromNode || x.Y == fromNode || x.X == toNode || x.Y == toNode) && x.C != currentMax).OrderByDescending(x => x.C).ToList();

                    foreach (var item in byCosts)
                    {
                        if (item.X != fromNode && item.X != toNode && !visitedNodes.Contains(item.X))
                        {
                            visitedNodes.Add(item.X);
                            fromNode = item.Y;
                            toNode = item.X;
                            result += item.C;
                            break;
                        }
                        else if (item.Y != fromNode && item.Y != toNode && !visitedNodes.Contains(item.Y))
                        {
                            visitedNodes.Add(item.Y);
                            fromNode = item.X;
                            toNode = item.Y;
                            result += item.C;
                            break;
                        }
                    }
                }

                Console.WriteLine(result);
            }
        }
    }

    public class PositionByCost
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int C { get; set; }
    }
}
