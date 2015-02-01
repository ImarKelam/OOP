namespace School
{
    using System;

    public abstract class Person
    {
        private string name;
        private string details = null;

        protected Person(string nm)
        {
            this.Name = nm;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The name can't be empty");
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }
    }
}
