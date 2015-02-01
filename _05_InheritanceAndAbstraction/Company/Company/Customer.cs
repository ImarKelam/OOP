namespace Company
{
    using System;

    public class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(string id, string firstName, string lastName, decimal netPurchaseAmount) : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if(value < 0m)
                    throw new ArgumentOutOfRangeException("The value of the net purchase amount can't be < 0");
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "  Net purchase amount: " + this.NetPurchaseAmount;
        }
    }
}
