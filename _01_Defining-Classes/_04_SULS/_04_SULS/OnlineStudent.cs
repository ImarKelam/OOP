namespace _04_SULS
{
    public class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, int age, string studentNumber, decimal avrgGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, avrgGrade, currentCourse)
        {

        }
    }
}
