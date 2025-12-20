using System;

// Base Account class
public abstract class Account
{
    public decimal Balance { get; protected set; }

    protected Account(decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance must be non-negative.");
        Balance = initialBalance;
    }

    public virtual void Credit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Credit amount must be positive.");
        Balance += amount;
    }

    public virtual bool Debit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Debit amount must be positive.");

        if (amount <= Balance)
        {
            Balance -= amount;
            return true;
        }

        Console.WriteLine("Debit amount exceeded account balance.");
        return false;
    }
}

// SavingsAccount
public class SavingsAccount : Account
{
    public decimal InterestRate { get; }

    public SavingsAccount(decimal initialBalance, decimal interestRate)
        : base(initialBalance)
    {
        InterestRate = interestRate;
    }

    public decimal CalculateInterest()
    {
        return Balance * InterestRate;
    }
}

// CheckingAccount
public class CheckingAccount : Account
{
    public decimal TransactionFee { get; }

    public CheckingAccount(decimal initialBalance, decimal fee)
        : base(initialBalance)
    {
        TransactionFee = fee;
    }

    public override void Credit(decimal amount)
    {
        base.Credit(amount);
        Balance -= TransactionFee;
    }

    public override bool Debit(decimal amount)
    {
        bool success = base.Debit(amount);
        if (success)
            Balance -= TransactionFee;
        return success;
    }
}

// Polymorphic Banking Application
class PolymorphicBankingTest
{
    static void Main()
    {
        Account[] accounts =
        {
            new SavingsAccount(1000.00m, 0.04m),
            new CheckingAccount(500.00m, 2.50m)
        };

        foreach (Account account in accounts)
        {
            Console.WriteLine($"\nCurrent Balance: {account.Balance:C}");

            Console.Write("Enter debit amount: ");
            decimal debitAmount = decimal.Parse(Console.ReadLine());
            account.Debit(debitAmount);

            Console.Write("Enter credit amount: ");
            decimal creditAmount = decimal.Parse(Console.ReadLine());
            account.Credit(creditAmount);

            // Check for SavingsAccount and apply interest
            if (account is SavingsAccount savings)
            {
                decimal interest = savings.CalculateInterest();
                savings.Credit(interest);
                Console.WriteLine($"Interest added: {interest:C}");
            }

            Console.WriteLine($"Updated Balance: {account.Balance:C}");
        }
    }
}