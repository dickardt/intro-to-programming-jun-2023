

using Banking.Domain;

namespace Banking.UnitTests.BankAccount;
public class WithdrawlGaurds
{
    [Fact]
    public void OverdraftNotAllowed()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();

        try
        {
            account.Withdraw(openingBalance + .01M);
        }
        catch (OverdraftException)
        {

        }

        Assert.Equal(openingBalance, account.GetBalance());
    }
    [Fact]
    public void OverdraftThrowsException()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();

        Assert.Throws<OverdraftException>(() => account.Withdraw(openingBalance + .01M));
    }
}
