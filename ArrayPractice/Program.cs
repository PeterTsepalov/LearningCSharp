using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Display(int[] array)
        {            
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(array[i]);            
            }
            Console.WriteLine();
        }
        static void Display(int[,] array)
        {
            
        }

        static void Main(string[] args)
        {
            int[] test = {2, 668888886, 8};
            Display(test);
            return;
            int[,] array = new int[2, 6]
            {
                { 10, 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20, 21 }
            };
            Display(array);
        }
    }
}
