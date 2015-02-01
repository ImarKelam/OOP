namespace School
{
    using System;
    using System.Collections.Generic;

    class Class
    {
        private string id;
        private IList<Teacher> teachers = new List<Teacher>();
        private IList<Student> students = new List<Student>();
        private string details = null;

        public Class(string id)
        {
            this.Id = id;
        }

        public string Id
        {
            get { return this.id; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The id can't be empty! ");
                this.id = value;
            }
        }

        public IList<Teacher> Teachers
        {
            get { return new List<Teacher>();}
        }

        public void AddTeacher(Teacher tch)
        {
            this.teachers.Add(tch);
        }

        public IList<Student> Students
        {
            get { return new List<Student>(this.students); }
        }

        public void AddStudent(Student st)
        {
            this.students.Add(st);
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        public override string ToString()
        {
            string output = "Class ID: " + this.Id + "\nTeachers: " + "\n";

            foreach (var teacher in this.teachers)
            {
                output += teacher.Name + "\n";
            }

            output += "Students:\n";
            foreach (var st in this.students)
            {
                output += st + "\n";
            }

            return output;
        }
    }
}
