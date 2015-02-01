namespace School
{
    using System;

    class Student : Person
    {
        private string studentId;

        public Student(string name, string id) 
            : base(name)
        {
            this.StudentId = id;
        }

        public string StudentId
        {
            get { return this.studentId; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The id can't be empty");
                this.studentId = value;
            }
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "    ID: " + this.StudentId;
        }
    }
}
