using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMent6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [][] studentScores = new int[3][];
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };
            int allTotal=0;
            int allAvg;
            int totalSub = 0;
            for(int i = 0; i < studentScores.Length; i++)
            {
                int total = 0;
                int avg;
                for(int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j]+"\t\t");
                    total = total + studentScores[i][j];
                    allTotal = allTotal + studentScores[i][j];
                }
                totalSub = totalSub + studentScores[i].Length;
                avg = total / studentScores[i].Length;
                Console.Write($"Avg : {avg}");
                Console.WriteLine();
            }
            allAvg = allTotal / totalSub;
            Console.WriteLine("\nThe Total Average of all the subjects is "+allAvg);
        }
    }
}
