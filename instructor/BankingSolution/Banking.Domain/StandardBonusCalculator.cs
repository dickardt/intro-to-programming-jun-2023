namespace Banking.Domain;

public class StandardBonusCalculator
{

    public decimal CalculateBonusForDepositOn(decimal balance, decimal amountOfDeposit)
    {
        if(balance > 5000M)
        {
            return amountOfDeposit * .10M;

        } else
        {
            return 0;
        }
    }
}