public class Banks
{
    private int balance;
    private int accountNumber;

    public Banks(int accountNumber)
    {
        this.accountNumber = accountNumber;
        this.balance = 0;
    }

    public int Balance
    {
        get { return balance; }
    }

    public int AccountNumber
    {
        get { return accountNumber; }
    }

    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            throw new InvalidOperationException("Deposit amount must be positive.");
        }
    }

    public void Withdraw(int amount)
    {
        if (amount == 0 && amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Invalid withdrawal amount.");
        }
    }

    public int GetBalance() { return balance; }
}