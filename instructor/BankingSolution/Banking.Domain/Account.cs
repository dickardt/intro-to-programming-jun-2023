namespace Banking.Domain;

public class Account
{
    private decimal _balance = 5000; // Fields class level variable
    public void Deposit(decimal amountToDeposit)
    {
        
        var bonusCalculator = new StandardBonusCalculator();
        decimal bonus = bonusCalculator.CalculateBonusForDepositOn(_balance, amountToDeposit);

        _balance += amountToDeposit + bonus;
    }

   

    public decimal GetBalance()
    {
        return _balance; // "Sliming"
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if(amountToWithdraw > _balance)
        {
            throw new OverdraftException();
        }
       _balance -= amountToWithdraw;
    }
}