using System;
namespace Exercise2
{
    public class Arithmetic
    {
        public int a=30;
        public int b = 50;
        public Arithmetic()
        {
        }

        public void Addition()
        {
            Console.WriteLine($"Sum= {a + b}"); 
        }
        public void Subtraction()
        {
            Console.WriteLine($"Subtraction= {a - b}");
        }
        public void Multiplication()
        {
            Console.WriteLine($"Multiplication= {a * b}");
        }
        public void Division()
        {
            Console.WriteLine($"Division= {a / b}");
        }

    }
}
