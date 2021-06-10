using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int second= Convert.ToInt32(Console.ReadLine());
            for (int i = first; i <= second; i++)
            {
                if (isArmstrong(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
        public static bool isArmstrong(int a)
        {
            bool result = false;
            int digit, temp = 0,sum=0;
            temp = a;
            while (temp != 0)
            {
                digit = temp % 10;
                sum = sum + digit * digit * digit;
                temp = temp / 10;
            }
            if (sum == a)
            {
                result = true;
            }
            return result;
        }
    }
}
