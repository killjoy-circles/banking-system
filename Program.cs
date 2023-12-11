// Program.cs

using System;

class Program
{
    static void Main()
    {
        // Create accounts
        Account account1 = new Account("12345", 1000);
        Account account2 = new Account("67890", 500);

        // Display initial balances
        Console.WriteLine("Initial Balances:");
        Console.WriteLine($"Account {account1.GetBalance()}: ${account1.GetBalance()}");
        Console.WriteLine($"Account {account2.GetBalance()}: ${account2.GetBalance()}");

        // Perform a transaction
        Transaction transaction = new Transaction(account1, account2, 300);
        transaction.Execute();

        // Display updated balances
        Console.WriteLine("\nUpdated Balances:");
        Console.WriteLine($"Account {account1.GetBalance()}: ${account1.GetBalance()}");
        Console.WriteLine($"Account {account2.GetBalance()}: ${account2.GetBalance()}");
    }
}
