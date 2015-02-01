namespace Human_Student_Worker
{
    using System;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Faculty number can't be empty");
                if (value.Length < 5 || value.Length > 10)
                    throw new ArgumentOutOfRangeException("The faculty number musth be between 5 and 10 characters/numbers. ");
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return "Name: " + base.ToString() + "    Faculty #: " + this.FacultyNumber;
        }
    }
}
