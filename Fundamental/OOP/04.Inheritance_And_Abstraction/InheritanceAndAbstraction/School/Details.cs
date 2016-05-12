using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Details
    {
        public string Description { get; set; }

        private const string noDetails = "No description available";

        public Details (string description)
        {
            this.Description = description;
        }
        public Details () : this(noDetails)
        {

        }

        public override string ToString()
        {
            return "Details: " + this.Description + ".";
        }
    }
}
