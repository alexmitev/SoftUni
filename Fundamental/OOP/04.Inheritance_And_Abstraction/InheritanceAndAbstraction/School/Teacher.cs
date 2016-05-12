using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Teacher : Person
    {

        public HashSet<Discipline> Disciplines { get; set; }

        public Teacher (string name, HashSet<Discipline> disciplines, string details) : base(name, details )
        {
            this.Disciplines = disciplines;
        }
        public Teacher (string name) : base(name)
        {
            this.Disciplines = new HashSet<Discipline>();
        }
        public Teacher () : base()
        {
            this.Disciplines = new HashSet<Discipline>();
        }

        public override string ToString()
        {
            StringBuilder toPrint = new StringBuilder();

            toPrint.AppendFormat("Teacher name: {0}\r\n", base.ToString());
            foreach (var dis in this.Disciplines)
            {
                toPrint.Append(dis.ToString() + "\n\r");
            }
            return toPrint.ToString();
        }

    }
}