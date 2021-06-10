using System;

namespace DemoTask
{
    public class Student
    {
        string Name, Address;
        int Mobile;
        public void GetDate()
        {
            Console.WriteLine("Enter your Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Address:");
            Address = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number:");
            Mobile = Convert.ToInt32(Console.ReadLine());
        }
        public void displayData()
        {
            Console.WriteLine("Student Name: "+Name);
            Console.WriteLine("Student Address: "+ Address);
            Console.WriteLine("Student Mobile Number: "+ Mobile);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetDate();
            s1.displayData();
            Console.ReadKey();
        }
    }
}
