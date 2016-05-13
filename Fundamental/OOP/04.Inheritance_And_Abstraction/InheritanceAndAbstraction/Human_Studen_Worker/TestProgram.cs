using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Studen_Worker
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            try
            {
                Student sasho = new Student("Alex", "Mitev", "alemiev19");
                Student nobody = new Student();
                Console.WriteLine(sasho.ToString());

                
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.ToString());
            }

            Worker emo = new Worker()
            {
                FirstName = "Emil",
                LastName = "Savov",
                WeekSalary = 400m,
                WorkHoursPerDay = 7
            };

            Console.WriteLine(emo.MoneyPerHour());

        }
    }
}
