using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Human_Studen_Worker
{
  public class Student : Human
    {
        private const string pattern = @"^[A-Za-z0-9]{5,10}$";
        private string facultyNumber;

        public Student (string firstName, string secondName, string facultyNumber) : base(firstName, secondName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public Student() : base()
        {

        }

        public string FacultyNumber
        {
            get
            {
                return facultyNumber;
            }

            set
            {
                Regex isValid = new Regex(pattern);

                if(!isValid.IsMatch(value))
                {
                    throw new FormatException("Invalid faculty number. The input must be letter and digits, between 5 and 10 characters");
                }
                facultyNumber = value;
            }

        }

        public override string ToString()
        {
            return base.ToString() + "Faculty number: " + this.FacultyNumber + "\n\r";
        }
    }
}
