namespace Company
{
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;

    public class SalesEmployee : Employee, ISalesEmployee
    {
        private IList<Sale> sales = new List<Sale>(); 

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, Departments department) 
            : base(id, firstName, lastName, salary, department)
        {
        }

        public IList Sales
        {
            get { return new List<Sale>(this.sales); }
        }

        public void AddSale(Sale s)
        {
            this.sales.Add(s);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(base.ToString() + "\nSales");

            foreach (var sale in this.Sales)
            {
                output.Append("\n" + sale);
            }

            return output.ToString();
        }
    }
}
