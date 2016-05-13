using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Define a class Worker derived from Human with fields WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns the payment earned by hour by the worker.
*/
namespace Human_Studen_Worker
{
   public  class Worker : Human
    {
        public decimal WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public Worker (string firstName, string secondName) : base(firstName,secondName)
        {

        } 
        
        public Worker () : base()
        {

        }
        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (decimal)(this.WorkHoursPerDay * 5);
        }

    }
}
