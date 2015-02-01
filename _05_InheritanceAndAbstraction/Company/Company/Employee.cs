namespace Company
{
    using System;

    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Departments department;

        public Employee(string id, string firstName, string lastName, decimal salary, Departments department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if(value < 1m)
                    throw new ArgumentOutOfRangeException("The salary can't be < 1 ");
                this.salary = value;
            }
        }

        public Departments Department
        {
            get { return this.department; }
            set
            {
                this.department = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "  Department: " + this.Department + "  Salary: " + this.Salary;
        }
    }
}
