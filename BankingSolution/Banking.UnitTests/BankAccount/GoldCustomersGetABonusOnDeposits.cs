

namespace Banking.UnitTests.BankAccount;
public class GoldCustomersGetABonusOnDeposits
{
    [Fact]
    public void BonusIsApplied()
    {
        var account = new Account();
        account._accountType = LoyaltyLevel.Gold;
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        var expectedNewBalance = openingBalance + amountToDeposit + 10M;

        account.Deposit(amountToDeposit);

        Assert.Equal(expectedNewBalance, account.GetBalance());
    }
}
