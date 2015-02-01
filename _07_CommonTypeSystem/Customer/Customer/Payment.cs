namespace Customer
{
    using System;

    public class Payment
    {
        private string productName;
        private double price;

        public Payment(string productName, double price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if(String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The product name can't be empty! ");
                this.productName = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if(value < 0)
                    throw new ArgumentOutOfRangeException("The price must be > 0 ");
                this.price = value;
            }
        }
    }
}
