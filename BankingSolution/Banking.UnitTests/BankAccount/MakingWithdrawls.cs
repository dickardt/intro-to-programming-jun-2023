

namespace Banking.UnitTests.BankAccount;

public class MakingWithdrawls
{
    [Fact]
    public void MakingAWithdrawl()
    {
        Account account = new Account();
        decimal openBal = account.balance;
        decimal withdrawlAmmount = 350.00M;

        account.Withdrawl(withdrawlAmmount);
        decimal afterBal = account.balance;

        Assert.Equal(openBal - withdrawlAmmount, afterBal);
    }
    [Fact]
    public void CanTakeFullBalance()
    {
        var account = new Account();
        var openingBalance = account.balance;

        account.Withdrawl(openingBalance);

        Assert.Equal(0, account.balance);
    }
}
