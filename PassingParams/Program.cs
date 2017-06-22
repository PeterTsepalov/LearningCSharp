using System;
namespace passingParams
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int input = 55;
            int res;
            res = IncrementInt(input);
            if (input == 55 && res == 56)
            {
                Console.WriteLine("As expected");   
            }
            else
            {
                Console.WriteLine("Something went wrong!");
			}
        }
        static int IncrementInt(int i)
        {
            i++;
            int res = i;
            return res;
			// Shortest correct return ++i; 
            // INCORRECT return i++;
		}
    }

}
