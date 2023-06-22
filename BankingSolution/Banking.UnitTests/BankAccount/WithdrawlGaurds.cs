

namespace Banking.UnitTests.BankAccount;
public class WithdrawlGaurds
{
    [Fact]
    public void OverdraftNotAllowed()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();

        account.Withdraw(openingBalance + .01M);

        Assert.Equal(openingBalance, account.GetBalance());
    }
}
