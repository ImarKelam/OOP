namespace Company
{
    using System;

    public abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        public Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id
        {
            get { return this.id; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The id can't be empty");
                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The first name can't be empty");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The last name can't be empty");
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return "First name: " + this.FirstName + "  Last name: " + this.LastName + "  ID: " + this.Id;
        }
    }
}
