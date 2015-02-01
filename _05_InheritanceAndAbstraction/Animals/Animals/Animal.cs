namespace Animals
{
    public abstract class Animal : ISound
    {
        private string name;
        private string gender;
        private int age;

        public Animal(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public abstract void ProduceSound();
    }
}
