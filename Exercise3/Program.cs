using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String: ");
            string input = Console.ReadLine();
            reverseString(input);
        }
        public static void reverseString(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            string newString = new string(chars);
            Console.WriteLine("New string is: "+newString);
        }
    }
}
