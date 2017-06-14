using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSpeedConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            const int maxSise = 10000;
            int value;
            int[,] rectangular = new int[maxSise, maxSise];
            int[][] jagged = new int[maxSise][];

            for (int i = 0; i < maxSise; i++)
            {
                jagged[i] = new int[maxSise];

                for (int j = 0; j < maxSise; j++)
                {
                    rectangular[i, j] = 666;
                    jagged[i][j] = 666;
                }
            }

            GC.Collect();// Making sure garbage collection will not kick during the test

            sw.Start();
            for (int i = 0; i < maxSise; i++)
            {
                for (int j = 0; j < maxSise; j++)
                {
                    value = rectangular[i, j];
                }
            }
            sw.Stop();
            var rectangularResult = sw.ElapsedTicks;

            sw.Start();
            for (int i = 0; i < maxSise; i++)
            {
                for (int j = 0; j < maxSise; j++)
                {
                    value = jagged[i][j];
                }
            }
            sw.Stop();
            var jaggedResult = sw.ElapsedTicks;
            Console.WriteLine(string.Format("rectangularResult {0} jaggedResult {1}", rectangularResult, jaggedResult));
            Console.ReadKey();
        }
    }
}
