

using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests.BankAccount;

public class MakingWithdrawls
{
    [Fact]
    public void MakingAWithdrawl()
    {
        Account account = new Account(new DummyBonusCalculator());
        decimal openBal = account.GetBalance();
        decimal withdrawlAmmount = 350.00M;

        account.Withdraw(withdrawlAmmount);
        decimal afterBal = account.GetBalance();

        Assert.Equal(openBal - withdrawlAmmount, afterBal);
    }
    [Fact]
    public void CanTakeFullBalance()
    {
        var account = new Account(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        account.Withdraw(openingBalance);

        Assert.Equal(0, account.GetBalance());
    }
}
