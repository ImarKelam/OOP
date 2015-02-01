namespace Bank
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customers customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest;

            if (base.Customer.Equals(Customers.Individual))
            {
                if (months < 7)
                    return 0m;
                else
                    interest = base.Balance*(1 + base.InterestRate/100*(months - 6)) - base.Balance;
            }

            else
            {
                if (months < 13)
                {
                    interest = (base.Balance * (1 + base.InterestRate / 100 * months) - base.Balance) / 2;
                }
                else
                {
                    interest = (base.Balance * (1 + base.InterestRate / 100 * 12) - base.Balance) / 2;
                    interest += (base.Balance*(1 + base.InterestRate/100*(months - 12)) - base.Balance);
                }
            }
                
            return interest;
        }

        public override void Deposit(decimal amount)
        {
            base.Balance += amount;
        }
    }
}
