using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class TestSchool

    {
        static void Main()
        {
            Student sasho = new Student("Sasho", 1744);
            Student nobody = new Student();
            Student geri = new Student("Geri", 1233, "New  to programing");

            Discipline math = new Discipline()
            {
                Name = "Mathematics",
                NumberOfLectures = 4,
                Students = new HashSet<Student>{sasho, nobody, geri},
                Description = "One of the hardest disciplines"

            };
            Teacher unknown = new Teacher();
           
            //Console.WriteLine(unknnow.ToString() + Environment.NewLine);

            unknown.Disciplines.Add(math);

            //Console.WriteLine(unknnow.ToString() + Environment.NewLine);


            Class programming = new Class()
            {
                Identifier = "Programming",
                Teachers = new HashSet<Teacher> { unknown},
                Students = new HashSet<Student> { sasho, nobody, geri}
            };
            foreach (var item in programming.Students)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
