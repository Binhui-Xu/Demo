using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int current = 0;
            for (int i = 1; i <= rows; i++)
            {
                printRow(i, ref current);
            }
        }
        public static void printRow(int row, ref int current)
        {
            int[] rowNumbers = new int[row];
            for (int i = 0; i < row; i++)
            {
                if (current == 0)
                {
                    rowNumbers[i] = 1;
                    current = 1;
                }
                else
                {
                    rowNumbers[i] = 0;
                    current = 0;
                }
            }
            Console.WriteLine(string.Join("", rowNumbers));
        }
    }
}
