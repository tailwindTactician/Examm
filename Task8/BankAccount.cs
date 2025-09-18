public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal Balance)
    {
        balance = Balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
