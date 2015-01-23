using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Defining_Classes
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, "")
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Name can not be empty!");
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                    throw new ArgumentException("The age must be in the range [1 ... 100]");
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    this.email = "(not set)";
                else if (!value.Contains("@"))
                    throw new ArgumentException("The email must contain @");
                else
                    this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Email: {2}", this.name, this.age, this.email);
        }
    }

    class _01_
    {
        static void Main(string[] args)
        {
            Person one = new Person("Kiro", 20, "kiro@pesho.com");
            Person two = new Person("Pesho", 30);

            Console.WriteLine(one);
            Console.WriteLine(two);
        }
    }
}
