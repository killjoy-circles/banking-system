// Transaction.cs

using System;

public class Transaction
{
    private Account sourceAccount;
    private Account destinationAccount;
    private decimal amount;

    public Transaction(Account sourceAccount, Account destinationAccount, decimal amount)
    {
        this.sourceAccount = sourceAccount;
        this.destinationAccount = destinationAccount;
        this.amount = amount;
    }

    public void Execute()
    {
        if (sourceAccount.GetBalance() >= amount)
        {
            sourceAccount.Withdraw(amount);
            destinationAccount.Deposit(amount);
            Console.WriteLine("Transaction successful");
        }
        else
        {
            Console.WriteLine("Transaction failed: Insufficient funds");
        }
    }
}
