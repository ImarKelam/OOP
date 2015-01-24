namespace _04_SULS
{
    using System;
    using System.Text;

    public class DropoutStudent : Student
    {
        public DropoutStudent(string firstName, string lastName, int age, string studentNumber, string dropoutReason, decimal avrgGrade) 
            : base(firstName, lastName, age, studentNumber, avrgGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason { get; set; }

        public void Reapply()
        {
            StringBuilder output = new StringBuilder();

            output.Append("Name: " + this.FirstName + " " + this.LastName + "  Age: " + this.Age + "  ID: " + this.StudentNumber);
            output.Append("\nDropout reason: " + this.DropoutReason);

            Console.WriteLine(output);
        }
    }
}
