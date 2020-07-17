using System;
using System.Xml.Schema;

namespace Lab02_ATM
{
    public class Program
    {
        static public decimal Balance = 1000;
        /// <summary>
        /// The method of all methods, we break if it breaks
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            try
            {
                UserInterface();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Will Display the 4 options as long as they do not choose option 4: Exit. This method also calls all other methods to be executed
        /// </summary>
        public static void UserInterface()
        {
            try
            {
                string userEntry = "0";
                while (userEntry != "4")
                {
                    Console.WriteLine("Welcome to the Bank of Bryant Financial, thank you for choosing us for your financial needs");
                    Console.WriteLine("Please select an option below:");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Withdrawl");
                    Console.WriteLine("3. Deposit");
                    Console.WriteLine("4. Exit");
                    userEntry = Console.ReadLine();
                    int.TryParse(userEntry, out int results);
                    if (results == 4)
                    {
                        Console.WriteLine("Thank you for using Bryant Financial, see you next time");
                        break;
                    }
                    else if (results == 1)
                    {
                        Console.WriteLine($"Your avilable balance is: {ViewBalance()}");
                    }
                    else if (results == 2)
                    {
                        Console.WriteLine("Enter the amount you wish to withdraw");
                        string withdraw = Console.ReadLine();
                        Decimal.TryParse(withdraw, out decimal result);
                        if (result < 0)
                        {
                            while (result < 0)
                            {
                                Console.WriteLine("You cannot withdraw a negative amount");
                                Console.WriteLine("Enter the amount you wish to withdraw");
                                withdraw = Console.ReadLine();
                                Decimal.TryParse(withdraw, out decimal positive);
                                result = positive;

                            }
                        }
                        else if (result > Balance)
                        {
                            while (result > Balance)
                            {
                                Console.WriteLine("You cannot withdraw an amount greater than your balance");
                                Console.WriteLine("Enter the amount you wish to withdraw");
                                withdraw = Console.ReadLine();
                                Decimal.TryParse(withdraw, out decimal positive);
                                result = positive;
                            }
                        }
                        Console.WriteLine($"Your new balance is: {Withdraw(result)}");
                    }
                    else if (results == 3)
                    {
                        Console.WriteLine("Enter the amount you wish to deposit");
                        string deposit = Console.ReadLine();
                        Decimal.TryParse(deposit, out decimal depositNumber);
                        if (depositNumber < 0)
                        {
                            while (depositNumber < 0)
                            {
                                Console.WriteLine($"Your new available is: {Balance}");
                                Console.WriteLine("You cannot deposit a negative amount");
                                Console.WriteLine("Enter the amount you wish to deposit");
                                deposit = Console.ReadLine();
                                Decimal.TryParse(deposit, out decimal newDepositNumber);
                                depositNumber = newDepositNumber;
                            }
                        }

                        Console.WriteLine($"Your new available balance is: {Deposit(depositNumber)}");

                    }

                }
            }
            catch (Exception e)
            {
                throw;
            }


        }
        /// <summary>
        /// When called will return the current available Balance.
        /// </summary>
        /// <returns>Balance</returns>
        public static decimal ViewBalance()
        {
            return Balance;
        }
        /// <summary>
        /// When called will check if number is leaas than zero, if so returns balance otherwise it will subtract the amount from balance and then return balance
        /// </summary>
        /// <param name="number">Number to be withdrawn</param>
        /// <returns>New Balance</returns>
        public static decimal Withdraw(decimal number)
        {
            if (number < 0)
            {
                return Balance;
            }
            else
            {
                decimal newBalance = Balance - number;
                Balance = newBalance;
                return Balance;

            }
        }
        /// <summary>
        /// Receives a number to be deposited from the user. Verifies the number is a positive amount and then adds that to the balance and returns the balance.
        /// </summary>
        /// <param name="deposit">Amount to be deposited</param>
        /// <returns>New Balance</returns>
        public static decimal Deposit(decimal deposit)
        {
            if (deposit < 0)
            {
                return Balance;
            }
            else
            {
                decimal final = deposit + Balance;
                Balance = final;
                return Balance;

            }
        }

    }
}
