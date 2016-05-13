using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Studen_Worker
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human (string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Human()
        {

        }

        public override string ToString()
        {
            return "First Name: " + this.FirstName + "\n\r"
                   + "Last Name: " + this.LastName + "\n\r";
        }


    }
}
