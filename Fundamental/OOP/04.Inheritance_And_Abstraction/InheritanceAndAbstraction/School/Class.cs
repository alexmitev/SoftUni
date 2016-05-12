using System;
using System.Collections.Generic;
using System.Text;


namespace School
{
   public class Class
    {
        private const string notDefinedClassName = "Class is not yet defined";
        public string Identifier { get; set; }

        public HashSet<Teacher> Teachers;

        public HashSet<Student> Students;

        public Class(string identifier)
        {
            this.Identifier = identifier;
            
        }
        public Class(string identifier, HashSet<Teacher> teachers, HashSet<Student> students) : this(identifier)
        {
            this.Teachers = teachers;
            this.Students = students;
        }
        public Class() : this(notDefinedClassName)
        {

        }

    }
}
