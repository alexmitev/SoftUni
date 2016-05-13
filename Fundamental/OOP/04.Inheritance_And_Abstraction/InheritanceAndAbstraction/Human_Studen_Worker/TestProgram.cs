using System;
using System.Collections.Generic;
using System.Linq;


namespace Human_Studen_Worker
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
               new Student("Alex", "Mitev", "alemiev19"),
               new Student("Emil", "Mitev", "alpev19"),
               new Student("Penko", "Savov", "123penko"),
               new Student("Tani", "Brankov", "branko14"),
               new Student("Stan", "Atanasov", "stan32at"),
               new Student("El", "Shi", "Shik28"),
               new Student("Mi", "shikinova", "shiki32"),
               new Student("Joro", "Kovachev", "25Jor"),
               new Student("Vasil", "Ivanchev", "Vasko25"),
               new Student("Toni", "Bugov", "123495")
             };


            Worker emo = new Worker()
            {
                FirstName = "Emil",
                LastName = "Savov",
                WeekSalary = 400m,
                WorkHoursPerDay = 7
            };

            List<Worker> workers = new List<Worker>()
            {
                emo,
                new Worker("Ivan", "Vankov", 320.50m, 10),
                  new Worker("Grigor", "Atanasov", 440m, 9),
                   new Worker("Stoyan", "Stoyanov", 720.50m, 7.5),
                  new Worker("Stiliyan", "Morov", 420m, 9),
                   new Worker("Silvia", "Morova", 350m, 8.5),
                  new Worker("Albena", "Dyakova", 540, 11),
                   new Worker("Ivan", "Stanchev", 750m, 10),
                  new Worker("Bobi", "Genchev", 320.50m, 10),
                  new Worker("Mimi", "Ivova", 510m, 8)
            };

            var sortedStudents = students.OrderBy(st => st.FacultyNumber).Select(st => st);

            ////Sort students by faculty number
            //foreach (var student in sortedStudents)
            //{
            //    Console.WriteLine(student.FacultyNumber);
            //}
            var sortedWorkers = workers.OrderByDescending(wk => wk.MoneyPerHour()).Select(wk => wk);

            //sort workers by money per hours
            //foreach (var worker in sortedWorkers)
            //{
            //    Console.WriteLine(worker.MoneyPerHour()); 
            //}


            var joinedList = students.Cast<Human>().Concat(workers).Select(x => new { Name = x.FirstName, LastName = x.LastName })
                             .OrderBy(x => x.Name).ThenBy(x => x.LastName).Select(x => x);

            foreach (var human in joinedList)
            {
                Console.WriteLine(human.Name + " " + human.LastName);
            }           
        
         


            

        }
    }
}
