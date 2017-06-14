using System;
using System.Diagnostics;

namespace ArraysSpeedConsole
{
    class Program
    {
        static void Main()
        {
            Stopwatch sw = new Stopwatch();
            const int maxSise = 10000;
            int[,] rectangular = new int[maxSise, maxSise];
            int[][] jagged = new int[maxSise][];

            for (int i = 0; i < maxSise; i++)
            {
                jagged[i] = new int[maxSise];

                for (int j = 0; j < maxSise; j++) // This loop can be ommitted if default 0s are ok
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
                    rectangular[j, i] = rectangular[i, j];
                }
            }
            sw.Stop();
            var rectangularResult = sw.ElapsedTicks;

            sw.Start();
            for (int i = 0; i < maxSise; i++)
            {
                for (int j = 0; j < maxSise; j++)
                {
                    jagged[j][i] = jagged[i][j];
                }
            }
            sw.Stop();
            var jaggedResult = sw.ElapsedTicks;
            Console.WriteLine("rectangularResult {0:0,0} jaggedResult {1:0,0}", rectangularResult, jaggedResult);
            Console.ReadKey();
        }
    }
}
