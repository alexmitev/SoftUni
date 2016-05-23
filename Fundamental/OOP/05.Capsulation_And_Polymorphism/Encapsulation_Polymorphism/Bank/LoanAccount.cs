using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank 
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(double months)
        {
            if(this.Customer is IndividualCustomer)
            {
                if (months - 3 > 0) { return base.CalculateInterest(months - 3); }
                return this.Balance;
            }
            else
            {
                if (months -2 > 0) { return base.CalculateInterest(months - 2); }
                return this.Balance;
            }
                  
            
        }
    }
}
