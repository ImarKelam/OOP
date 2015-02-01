using System.Text;
using System.Xml;

namespace School
{
    using System;
    using System.Collections.Generic;

    class Discipline
    {
        private string name;
        private int numberOfLectures;
        private IList<Student> students = new List<Student>();
        private string details = null;

        public Discipline(string nm, int numLec)
        {
            this.Name = nm;
            this.NumberOfLectures = numLec;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The name can't be empty! ");
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("The number of lectures must be > 0 ");
                this.numberOfLectures = value;
            }
        }

        public IList<Student> Students
        {
            get { return new List<Student>(this.students); }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        public void AddStudent(Student st)
        {
            this.students.Add(st);
        }

        public override string ToString()
        {
            StringBuilder ouput = new StringBuilder();

            ouput.Append("Course name: " + this.name + "\nNumber of lectures: " + this.numberOfLectures + "\nStudents:");

            foreach (var student in students)
            {
                ouput.Append("\n" + student );
            }

            ouput.Append("\n");
            return ouput.ToString();
        }
    }
}
