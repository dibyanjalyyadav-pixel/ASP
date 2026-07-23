using System;
class BankAccount
{
    public int AccountNumber { get; set; }
    private double balance;

    public double Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value >= 0)
                balance = value;
            else
                Console.WriteLine("balance cannot be negative");
        }
    }

}
class Prograqm
{
    static void Main()
    {
        BankAccount b = new BankAccount();

        b.AccountNumber = 101;
        b.Balance = 5000;
        Console.WriteLine("Account Number = " + b.AccountNumber);
        Console.WriteLine("Balance = " + b.Balance);

        b.Balance = 1000;

    }
}

