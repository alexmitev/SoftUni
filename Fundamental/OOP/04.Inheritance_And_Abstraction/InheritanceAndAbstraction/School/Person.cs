using System;


namespace School
{
    public abstract class Person : Details
    {
        protected string name;
        private const string unknownName = "Unknown";

        protected  Person (string name, string details) : base(details) 
        {
            this.Name = name;
        }

        protected Person () : this(unknownName)
        {

        }
        
        protected Person (string name) : base()
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name + "\n\r" + base.ToString(); 
        }



    }
}
