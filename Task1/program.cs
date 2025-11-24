namespace BankExample;

class program
{
    static void Main(string[] args)
    {
        // Create a bank account object
        BankAccount account = new BankAccount("John Doe", 100);
        
        // Display account number
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Initial Balance: {account.Balance}");
        
        // Deposite Money
        account.Deposit(100);
        
        // Withdraw Money
        account.Withdraw(50);

    }
}