using System;


namespace H1_BankAccount_Opgave
{
    public class BankAccount
    {
        public double balance;

        /// <summary>
        /// Constructor to initialize the initial balance.
        /// </summary>
        /// <param name="initialBalance">Starting balance</param>
        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        /// <summary>
        /// Public property for accessing the balance.
        /// </summary>
        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        /// <summary>
        /// Method to deposit an amount into the account.
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount} kr. \nNew balance: {Balance} kr.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }


        /// <summary>
        /// Method to withdraw an amount from the account.
        /// </summary>
        /// <param name="amount">Amount to withdraw</param>
        /// <returns>Returns true if the withdrawal is successful, false otherwise</returns>
        public virtual bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount} kr. \nNew balance: {Balance} kr.");
                return true;
            }
            Console.WriteLine("Invalid withdraw amount.");
            PrintBalance();
            return false;
        }

        /// <summary>
        /// Method to print the current balance.
        /// </summary>
        public void PrintBalance()
        {
            Console.WriteLine($"Balance: {balance} kr.");
        }
    }
}
