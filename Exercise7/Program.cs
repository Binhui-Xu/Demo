using System;

namespace Exercise7
{
    class Program
    {
        private int balance = 1000;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Pin Number");
            int pin = Convert.ToInt32(Console.ReadLine());
            if (pin == 123)
            {
                Console.WriteLine("********* Welcome to ATM Service ***********");
                bool quit = false;
                Program p = new Program();
                while (!quit)
                {
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Withdrwa Cash");
                    Console.WriteLine("3. Deposite Cash");
                    Console.WriteLine("4. Quit");
                    Console.WriteLine("*******************************************");
                    Console.WriteLine("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            p.CheckBanlance();
                            break;
                        case 2:
                            Console.WriteLine("Enter the amount you want to withdraw: ");
                            int wamount = Convert.ToInt32(Console.ReadLine());
                            p.WithDrawCash(wamount);
                            break;
                        case 3:
                            Console.WriteLine("Enter the amount you want to deposite: ");
                            int damount = Convert.ToInt32(Console.ReadLine());
                            p.DepositeCash(damount);
                            break;
                        case 4:
                            quit = true;
                            break;
                        default:
                            Console.WriteLine("default case");
                            break;
                    }
                }
            }
            
        }
        public void CheckBanlance()
        {
            Console.WriteLine("YOU'RE BALANCE IN Rs: " + balance+ "\t\n");
        }
        public void WithDrawCash(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("YOU'RE BALANCE IN Rs: "+balance+ "\t\n");
        }
        public void DepositeCash(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("YOU'RE BALANCE IN Rs: " + balance+ "\t\n");
        }
    }
}
