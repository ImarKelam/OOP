namespace Company
{
    using System;

    public enum Departments
    {
        Production, Accounting, Sales, Marketing
    }

    public interface  IEmployee
    {
        decimal Salary { get; set; }
        Departments Department { get; set; }
    }
}
