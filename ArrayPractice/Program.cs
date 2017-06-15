using System;

namespace ArrayPractice
{
    class Program
    {        
        static void Display(int[,] array)
        {
            var maxValue = GetMaxValue(array);
            int padding = maxValue.ToString().Length + 2;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(padding));
                }
                Console.WriteLine();
            }
        }

        static int GetMaxValue(int[,] array)
        {
            int maxValue = int.MinValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxValue < array[i, j])
                    {
                        maxValue = array[i, j];
                    }
                }
            }
            return maxValue;
        }       

        static void Main()
        {
            int[] test = {2, 6, 8};
            Display(test);
            Console.WriteLine();
            int[,] array = new int[2, 3]
            {
                { 10, 11, 12 },
                { 16, 17, 18 }
            };
            Display(array);
            Console.ReadKey();
        }
    }
}
