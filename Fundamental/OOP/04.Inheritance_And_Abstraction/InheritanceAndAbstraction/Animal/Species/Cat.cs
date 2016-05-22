using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Species
{
    class Cat : Animal, ICat
    {
        public Cat (string name, int age, Gender gender) : base(name, age, gender)
        {

        }
        public Cat () : base()
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Mayyyyyy");
        }
    }
}
