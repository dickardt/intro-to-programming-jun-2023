namespace Banking.Domain
{
    public class Account
    {
        public decimal balance { get; set; }
        public Account()
        {
            balance = 5000;
        }

        public void Deposit(decimal addAmmount)
        {
            balance += addAmmount;
        }

        public void Withdrawl(decimal removeAmmount)
        {
            balance -= removeAmmount;
        }
    }
}