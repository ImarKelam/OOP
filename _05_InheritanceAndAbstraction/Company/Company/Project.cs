namespace Company
{
    using System;

    public class Project : IProject
    {
        private string name;
        private DateTime startDate;
        private string details;
        private ProjectState state;

        public Project(string name, DateTime startDate, string details)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = ProjectState.open;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The name of the project can't be empty! ");
                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get { return  this.startDate; }
            set { this.startDate = value; }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if(String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Project details can't be empty! ");
                this.details = value;
            }
        }

        public ProjectState State
        {
            get { return this.state; }
            set
            {
                this.state = value;
            }
        }

        public void CloseProject()
        {
            this.State = ProjectState.closed;
        }

        public override string ToString()
        {
            string output = "Name: " + this.Name + "  Start date: " + + this.startDate.Day + "." + this.startDate.Month + "." + this.startDate.Year
                + "  Details: " + this.Details + "  Project state: " + this.State;

            return output;
        }
    }
}
