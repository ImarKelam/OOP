namespace Bank
{
    using System;

    public abstract class Account : IAccount
    {
        private Customers customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(Customers customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customers Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The value can't be < 0 ");
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set 
            { 
                if(value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("The interest has to be between 0 and 100% ");
                this.interestRate = value;
            }
        }

        public abstract decimal CalculateInterest(int months);
        public abstract void Deposit(decimal amount);
    }
}
