﻿


using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests.BankAccount;

public class MakingDeposits
{
    [Fact]
    public void DepositIncreasesBalance()
    {
        Account account = new Account(new DummyBonusCalculator());
        decimal openBal = account.GetBalance();
        decimal deposit = 350.00M;

        account.Deposit(deposit);
        decimal endBalance = account.GetBalance();

        Assert.Equal(openBal+deposit, endBalance);
    }
}
