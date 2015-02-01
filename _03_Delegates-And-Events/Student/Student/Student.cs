using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    

    class Student
    {
        public delegate void PropertyChange(string str);
        public event PropertyChange ChangeEvent;

        private string name;
        private string oldName;

        private int age;
        private int oldAge;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("You must enter a name! ");
                else if (this.name == null)
                    this.name = value;
                else
                {
                    this.oldName = name;
                    this.name = value;
                    if (ChangeEvent != null)
                        ChangeEvent("Property changed: Name (from " + this.oldName + " to " + this.name + ")");
                }
               
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("The age must be > 0 ");
                else if (this.age > 0)
                {
                    this.oldAge = this.age;
                    this.age = value;
                    if (ChangeEvent != null)
                        ChangeEvent("Property changed: Age (from " + this.oldAge + " to " + this.age + ")");
                }
                else
                    this.age = value;
            }
        }


    }
}
