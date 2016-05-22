using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Animal.Species
{
    class AnimalTest
    { 
        static void Main(string[] args)
        {
            Kitten puppy = new Kitten();
            puppy.Gender = Gender.Male;
    

            var animals = new List<Animal>()
            {
                new Kitten("pup", 1),
                new Kitten("pis", 2),
                new Cat ("Pisan", 5, Gender.Female),
                new Cat ("veteran", 12, Gender.Female),
                new TomCat ("Tom", 8),
                new TomCat(),
                new TomCat("Jerry", 10),
                new Dog ("Cezar", 5, Gender.Female),
                new Dog ("Zuzy", 12, Gender.Male),
                new Dog ("Pully", 3, Gender.Female)

            };

            var groupedByAnimal =
                from animal in animals
                group animal by animal.GetType() into groups
                select new { GroupName = groups.Key, AverageAge = groups.Average(x => x.Age) };

            foreach (var animal in groupedByAnimal)
            {
                Console.WriteLine(String.Format("Animal: {0}, Average age: {1:F2}", animal.GroupName.Name, animal.AverageAge));
            }

            


        }
    }
}

