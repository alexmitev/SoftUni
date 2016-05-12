using System;
using System.Text;
using System.Collections.Generic;

namespace School
{
    public class Discipline : Details
    {

        private const string nameNotDefined = "Not defined";
       

        public HashSet<Student> Students { get; set; }

        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public Discipline (string name, int numberOfLectures, HashSet<Student> students, string details) : base(details)
        {
            this.Name = name;

            this.NumberOfLectures = numberOfLectures;

            this.Students = students;
        }

        public Discipline () : base()
        {
            this.Name = nameNotDefined;
        }

        public override string ToString()
        {
            StringBuilder toPrint = new StringBuilder();

            toPrint.AppendFormat("Discipline: {0} \n\rCount of lecturers: {1}\r\n{2}\r\n", this.Name, this.NumberOfLectures, base.ToString());

            foreach (var student in this.Students)
            {
                toPrint.Append(student.ToString() + "\n\r");
            }

            return toPrint.ToString();
        }
    }
}
