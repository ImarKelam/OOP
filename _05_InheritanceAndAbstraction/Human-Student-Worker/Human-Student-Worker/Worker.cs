namespace Human_Student_Worker
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if(value < 1)
                    throw new ArgumentOutOfRangeException("The week salary can't be < 1");
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("The daily work hours can't be < 1");
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = this.weekSalary / (this.WorkHoursPerDay * 5);

            return moneyPerHour;
        }

        public override string ToString()
        {
            string output = this.FirstName + " " + this.LastName + " " + "paid " + this.MoneyPerHour() + " lv/h";

            return output;
        }
    }
}
