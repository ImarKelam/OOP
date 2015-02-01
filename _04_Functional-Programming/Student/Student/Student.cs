namespace Student
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;
        private string groupName;

        public Student(string fName, string lName, int age, string facNumber, string phone,
            string email, IList<int> marks, int grpNumber)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            FacultyNumber = facNumber;
            Phone = phone;
            Email = email;
            Marks = marks;
            GroupNumber = grpNumber;
        }

        public string FirstName
        {
            get { return firstName; }
            set 
            {
                if (value == null)
                    throw new ArgumentNullException();
                firstName = value; 
            }
        }

        public string LastName 
        {
            get { return lastName; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                lastName = value;
            }
        }
        public int Age 
        { 
            get { return age; } 
            set
            {
                if (value < 1)
                    throw new ArgumentNullException();
                age = value;
            }
        }
        public string FacultyNumber 
        { 
            get { return facultyNumber; } 
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                facultyNumber = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                phone = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                email = value;
            }
        }
        public IList<int> Marks
        {
            get { return marks; }
            set
            { marks = value; }
        }
        public int GroupNumber
        {
            get { return groupNumber; }
            set
            {
                if (value < 0)
                    throw new ArgumentNullException();
                groupNumber = value;
            }
        }

        public string GroupName
        {
            get { return groupName; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                groupName = value;
            }
        }

        public override string ToString()
        {
            string output = "First name: " + firstName + "\nLast name: " + lastName + "\nAge: " + age
                + "\nFaculty number: " + facultyNumber + "\nPhone: " + phone + "\nEmail: " + email + "\nMarks: ";
            
            foreach (var mark in marks)
            {
                output += mark + " ";
            }

            output += "\nGroup number: " + groupNumber + "\n\n";

            return output;
        }
    }
}
