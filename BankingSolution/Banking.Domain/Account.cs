namespace Banking.Domain
{
    public enum LoyaltyLevel { Standard, Gold};
    public class Account
    {
        private decimal _balance = 5000; // Fields class level variable
        public LoyaltyLevel _accountType { get; set; } = LoyaltyLevel.Standard;
        public void Deposit(decimal amountToDeposit)
        {
            if (_accountType == LoyaltyLevel.Standard)
            {
                _balance += amountToDeposit;
            } 
            else
            {
                _balance += amountToDeposit * 1.10M;
            }
        }

        public decimal GetBalance()
        {
            return _balance; // "Sliming"
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > _balance)
            {
               throw new OverdraftException();
            }
            _balance -= amountToWithdraw;
        }
    }
}