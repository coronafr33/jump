using System;

class BankAccount
{
    public string AccountNumber { get; set; }

    private decimal balance;

    public decimal Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    "Balance cannot be negative."
                );
            }

            balance = value;
        }
    }

    public BankAccount(string accountNumber, decimal balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public void Display()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("101", 5000);

        account.Display();

        try
        {
            account.Balance = -1000;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("Current Balance: " + account.Balance);
    }
}