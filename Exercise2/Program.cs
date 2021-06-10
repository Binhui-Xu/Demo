using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arithmetic = new Arithmetic();
            Console.WriteLine("Enter an operator: ");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    arithmetic.Addition();
                    break;
                case "-":
                    arithmetic.Subtraction();
                    break;
                case "*":
                    arithmetic.Multiplication();
                    break;
                case "/":
                    arithmetic.Division();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
