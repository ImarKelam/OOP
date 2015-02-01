namespace Company
{
    using System.Text;
    using System.Collections.Generic;

    public class Developer : Employee, IDeveloper
    {
        private IList<Project> projects = new List<Project>(); 

        public Developer(string id, string firstName, string lastName, decimal salary, Departments department) 
            : base(id, firstName, lastName, salary, department)
        {
        }

        public IList<Project> Projects
        {
            get { return new List<Project>(this.projects); }
        }

        public void AddProject(Project pr)
        {
            this.projects.Add(pr);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(base.ToString() + "\nProjects:");

            foreach (var pr in this.Projects)
            {
                output.Append("\n" + pr);
            }

            return output.ToString();
        }
    }
}
