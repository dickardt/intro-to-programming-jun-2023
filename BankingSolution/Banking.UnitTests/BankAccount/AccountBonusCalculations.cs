using Banking.UnitTests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.BankAccount;
public class AccountBonusCalculations
{
    [Fact]
    public void DepositUsesTheBonusCalculator()
    {
        var account = new Account(new StubbedBonusCalculator());
        var openingBalance = account.GetBalance();

        account.Deposit(112);

        Assert.Equal(openingBalance + 112M +42M, account.GetBalance());
    }
}
