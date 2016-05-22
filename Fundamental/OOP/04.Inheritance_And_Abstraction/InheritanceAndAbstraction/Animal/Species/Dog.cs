using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Animal.Species
{
    class Dog : Animal
    {
        public Dog (string name, int age, Gender gender) : base(name, age, gender)
        {

        }
        public Dog () : base ()
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Bay bay bay");
        }
    }
}


