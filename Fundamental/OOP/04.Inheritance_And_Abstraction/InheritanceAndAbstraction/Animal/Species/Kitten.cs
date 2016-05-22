using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Species
{
    class Kitten : Cat
    {
        private const Gender female = Gender.Male;
        private Gender gender;
        

        public Kitten (string name, int age) 
        {
            this.Name = name;
            this.Age = age;
            this.Gender = female;
        }
        public Kitten ()  : base()
        {
            base.Gender = Gender.Female;
        }

        public override Gender Gender
        { 
            get
            {
                return base.Gender;
            }
            set
            {
                if (value != Gender.Female )
                {
                    throw new FormatException("Gender can only be female");
                }
               this.gender = value;
               
            }

        }
    }
}
