namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MainCLass
    {
        public static void Main()
        {
            IList<Dog> dogs = new List<Dog>
            {
                new Dog("Sharo", "male", 5),
                new Dog("Rex", "male", 2),
                new Dog("Balkan", "male", 1),
                new Dog("Sara", "female", 3),
                new Dog("Bucksy", "female", 6)
            };

            IList<Frog> frogs = new List<Frog>
            {
                new Frog("Ara", "female", 2),
                new Frog("Kikirica", "female", 3),
                new Frog("Stamat", "male", 5)
            };

            IList<Cat> cats = new List<Cat>
            {
                new Tomcat("Ricky", 3),
                new Kitten("Roxy", 1),
                new Kitten("Becky", 2),
                new Tomcat("Pesho", 5)
            };

            var avarageDogsAge = dogs.Average(d => d.Age);
            Console.WriteLine("Dogs avarage age is: " + avarageDogsAge + " years.");

            var avarageFrogsAge = frogs.Average(f => f.Age);
            Console.WriteLine("Frogs average age is: " + avarageFrogsAge + " years.");

            var avarageCatsAge = cats.Average(c => c.Age);
            Console.WriteLine("Cats average age is: " + avarageCatsAge + " years.");

            Console.WriteLine("\n" + cats[0].Gender);
            cats[0].ProduceSound();

            Console.WriteLine("\n" + cats[1].Gender);
            cats[1].ProduceSound();
        }
    }
}
