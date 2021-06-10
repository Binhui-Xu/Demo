using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int space = rows - 1;
            for (int row = 1; row <= rows; row++)
            {
                for (int i = 1; i <= space; i++)
                {
                    Console.Write(" ");
                }
                space--;
                for (int j = 1; j <= row * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            space = 1;
            for (int row = 1; row <= rows-1; row++)
            {
                for (int i = 1; i <= space; i++)
                {
                    Console.Write(" ");
                }
                space++;
                for (int j = 1; j <= 2 * (rows - row) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
