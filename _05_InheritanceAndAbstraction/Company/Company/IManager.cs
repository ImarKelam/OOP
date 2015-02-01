namespace Company
{
    using System.Collections.Generic;

    public interface IManager
    {
        IList<Employee> Employees { get; }
        void AddEmployee(Employee emp);
    }
}
