using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Species
{
    class TomCat : Cat
    {
        private const Gender male = Gender.Male;

        public TomCat (string name, int age) : base(name, age, male)
        {

        }
        public TomCat() : base()
        {
            base.Gender = male;
        }

        public override Gender Gender
        {
            get
            {
                return base.Gender;
            }
        }
    }
}
