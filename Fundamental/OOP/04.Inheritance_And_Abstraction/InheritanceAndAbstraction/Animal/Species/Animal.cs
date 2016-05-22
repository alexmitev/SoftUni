using System;

namespace Animal.Species
{
    public abstract class Animal : ISound, IAnimal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public virtual Gender Gender { get; set; }

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Animal()
        {

        }

        public abstract void ProduceSound();
    }
}

