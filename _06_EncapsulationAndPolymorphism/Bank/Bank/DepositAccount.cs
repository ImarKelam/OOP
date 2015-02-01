using System;

namespace Bank
{
    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customers customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0m;

            if (base.Balance < 1000m)
                return interest;
            else
                interest = base.Balance*(1 + base.InterestRate/100*months) - base.Balance;

            return interest;
        }

        public override void Deposit(decimal amount)
        {
            base.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(base.Balance - amount < 0)
                throw new ArgumentOutOfRangeException("Not enough balance in the account. ");
            base.Balance -= amount;
        }
    }
}
