using System;

namespace Company
{
    public class Sale : ISale
    {
        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        private string productName;
        private DateTime date;
        private decimal price;

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if(String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The sale name can't be empty! ");
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if(value < 1m)
                    throw new ArgumentOutOfRangeException("The price of the sale can't be < 1 ");
                this.price = value;
            }
        }

        public override string ToString()
        {
            string output = "Product name: " + this.ProductName + "  Date: " + this.date.Day + "." + this.date.Month + "." + this.date.Year + "  Price: " + this.Price;

            return output;
        }
    }
}
