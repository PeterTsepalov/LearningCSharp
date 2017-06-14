using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 6]
            {
                { 10, 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20, 21 }
            };
            Console.Write(array);
        }
    }
}
