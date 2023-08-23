using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_BankAccount_Opgave
{
    internal class UserInterface
    {
        public UserInterface() 
        {
            Console.WriteLine("Welcome to H1-Banking Systems");
            Console.ReadKey();

            BankAccount account = new BankAccount(1000);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select an option \n");

                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. See Balance");
                Console.WriteLine("4. Exit");
                Console.Write("> ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: // Deposit
                        Console.Clear();
                        Console.Write("Enter deposit amount: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        Console.WriteLine("\nPress Enter To Continue...");
                        Console.ReadKey();
                        break;
                    case 2: // Withdraw
                        Console.Clear();
                        Console.Write("Enter withdraw amount: ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        Console.WriteLine("\nPress Enter To Continue...");
                        Console.ReadKey();
                        break;
                    case 3: // See Balance
                        Console.Clear();
                        account.PrintBalance();
                        Console.WriteLine("\nPress Enter To Continue...");
                        Console.ReadKey();
                        break;
                    case 4: // Exit
                        return;
                    default:
                        Console.WriteLine("Not a valid option\nPress Enter To Try Again...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        
    }
}
