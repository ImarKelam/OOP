namespace Company
{
    using System.Collections.Generic;
    using System.Text;

    class Manager : Employee, IManager
    {
        private IList<Employee> employees = new List<Employee>();

        public Manager(string id, string firstName, string lastName, decimal salary, Departments department) 
            : base(id, firstName, lastName, salary, department)
        {

        }

        public IList<Employee> Employees
        {
            get { return new List<Employee>(this.employees); }
        }

        public void AddEmployee(Employee emp)
        {
            this.employees.Add(emp);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(base.ToString() + "\nEmployees: ");

            foreach (var em in this.Employees)
            {
                output.Append("\n" + em);
            }

            return output.ToString();
        }
    }
}
