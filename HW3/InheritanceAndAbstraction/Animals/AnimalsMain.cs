namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnimalsMain
    {
        static void Main()
        {
            Animal frog1 = new Frog("Kekerica", 3, Gender.Female);
            Animal frog2 = new Frog("RandomFrog", 2, Gender.Male);
            Animal frog3 = new Frog("Pesho", 1, Gender.Male);
            Animal tomcat1 = new Tomcat("Tom", 5);
            Animal kitten1 = new Kitten("Pepa", 3);
            Animal dog1 = new Dog("Balkan", 7, Gender.Male);

            List<Animal> animalList = new List<Animal>()
            {
                frog1,
                frog2,
                frog3,
                tomcat1,
                kitten1,
                dog1
            };

            var groupedAnimals = from animal in animalList
                                 group animal by animal.GetType() into type
                                 select new { GroupName = type.Key, AverageAge = type.Average(x => x.Age) };
            foreach (var animal in groupedAnimals)
            {
                Console.WriteLine("Type of animal: {0} -> {1:N2}",animal.GroupName.Name,animal.AverageAge);
            }

        }
    }
}
