using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class PersonMain

    {
        static void Main(string[] args)
        {

        List<Person> people = new List<Person>()
        {
            new Person("sasho", 30, "alex.mi@abv.bg"),
            new Person("emo", 28),
            new Person("mariya", 32, "mar@gmail.com"),
            new Person("toshko", 33)
        };

        foreach (var person in people)
        {
            Console.WriteLine(person.ToString() ); 
        }
        try
        {
            people.Add(new Person("", 19));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        
        }
    }

