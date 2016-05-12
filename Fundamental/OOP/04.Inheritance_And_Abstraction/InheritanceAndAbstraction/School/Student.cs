using System;

namespace School
{
   public class Student : Person
    {
        public int Id { get; set; }

        public Student (string name, int id) : base(name)
        {
            this.Id = id;
        }

        public Student (string name, int id, string details) : base(name, details)
        {
            this.Id = id;
        }
        
        public Student () : base()
        {
            this.Id = 0;
        }

     

        public override string ToString()
        {
            return String.Format("Student name: {0}\r\nId: {1}", base.ToString(), this.Id );
        }

    }
}
