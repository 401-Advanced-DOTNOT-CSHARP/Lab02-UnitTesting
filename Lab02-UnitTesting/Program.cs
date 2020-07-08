using System;

namespace Lab02_UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface();
        }

        static void UserInterface()
        {
            try
            {
                Console.WriteLine("Welcome to the Bank of Bryant Financial, thank you for choosing us for your financial needs");
                Console.WriteLine("Please select an option below:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdrawl");
                Console.WriteLine("4. Exit");
                string userEntry = Console.ReadLine();
                int userNumber = Convert.ToInt32(userEntry);
            }
            catch (Exception e)
            {

                throw;
            }


        }
    }
}
