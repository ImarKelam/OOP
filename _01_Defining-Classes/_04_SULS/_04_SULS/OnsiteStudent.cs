namespace _04_SULS
{
    class OnsiteStudent : CurrentStudent
    {
        public OnsiteStudent(string firstName, string lastName, int age, string studentNumber, decimal avrgGrade, string currentCourse, int visits = 0)
            : base(firstName, lastName, age, studentNumber, avrgGrade, currentCourse)
        {
            this.NumberOfVisits = visits;
        }

        public int NumberOfVisits { get; set; }

        
    }
}
