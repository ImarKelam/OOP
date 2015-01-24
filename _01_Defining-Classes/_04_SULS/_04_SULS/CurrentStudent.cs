namespace _04_SULS
{
    public abstract class CurrentStudent : Student
    {
        public CurrentStudent(string firstName, string lastName, int age, string studentNumber, decimal avrgGrade, string currentCourse) 
            : base(firstName, lastName, age, studentNumber, avrgGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse { get; set; }
    }
}
