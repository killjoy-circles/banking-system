// Account.cs

using System;

public class Account
{
    private string accountNumber;
    private decimal balance;

    public Account(string accountNumber, decimal balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
