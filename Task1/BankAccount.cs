using System;
namespace BankExample
{
    /*BankAccount class*/
    public class BankAccount {
        /*// private field*/
        private string accountName;
        private double balance;
    // / / Adding constructor 
        public BankAccount(string accountName, double initialBalance)
        {
            this.accountName = accountName;
            if (initialBalance <= 0)
            {
                throw new ArgumentException("Initial balance must be greater than zero");
    }

        this.balance = initialBalance;
    }
        // public property for AccountNumber
        public string AccountNumber
        {
            get { return accountName; }
        }

        /*// Public property for AccountNumber (read-only)*/

        public double Balance {
            get {
                return balance;
            }

            private set {
                if (value <= 0) {
                throw new ArgumentException("Balance must be greater than zero");
            }
                balance = value;
            }
        }

        /*// Method to deposit money*/
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposite must be greater than zero");
                return;
            }

            balance += amount;
            Console.WriteLine($"Sucessfully balance deposited {amount}.New Balance: {balance}");
        }
        

        /*// Method to withdraw money*/
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawl must be grater than zero");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance for this withdrawal");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Sucessfully withdraw {amount}. Remaining balance: {balance}");
        }
    } 
}