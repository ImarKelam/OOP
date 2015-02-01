namespace Bank
{
    class LoanAccount : Account
    {
        public LoanAccount(Customers customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest;

            if(base.Customer.Equals(Customers.Individual))
                interest = base.Balance * (1 + base.InterestRate / 100 * (months-3)) - base.Balance;
            else
                interest = base.Balance * (1 + base.InterestRate / 100 * (months - 2)) - base.Balance;

            return interest;
        }

        public override void Deposit(decimal amount)
        {
            base.Balance += amount;
        }
    }
}
