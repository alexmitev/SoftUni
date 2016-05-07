using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    //Define a class Person that has name, age and email.The name and age are mandatory.The email is optional.Define properties that accept non-empty name and age in the range [1 ... 100]. In case of invalid arguments, throw an exception. Define a property for the email that accepts either null or non-empty string containing '@'. Define two constructors.The first constructor should take name, age and email.The second constructor should take name and age only and call the first constructor. Implement the ToString() method to enable printing persons at the console.
    public class Person
    {

        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null)
        {

        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");

                }
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 1 && value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age is out of range");
                }
                age = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
              

                email = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Person name: {0}, Age: {1}, Email: {2}.", this.name, this.age, this.email == null ? "Empty" : this.email);
        }
    }


