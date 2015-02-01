using System.Text;

namespace School
{
    using System.Collections.Generic;

    class Teacher : Person
    {
        private IList<Discipline> disciplines = new List<Discipline>();

        public Teacher(string nm) : base(nm)
        {

        }

        public IList<Discipline> Disciplines
        {
            get {return new List<Discipline>(this.disciplines);}
        }

        public void AddDiscipline(Discipline dis)
        {
            this.disciplines.Add(dis);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append("Name: " + this.Name + "\nDisciplines: " + "\n");

            foreach (var discipline in this.disciplines)
            {
                output.Append("- " + discipline.Name + "\n");
            }

            if (this.Details != null)
                output.Append("Details: " + this.Details);

            return output.ToString();
        }
    }
}
