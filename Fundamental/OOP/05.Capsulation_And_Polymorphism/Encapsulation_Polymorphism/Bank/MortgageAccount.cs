using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, double interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(double months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if(months > 6)
                {
                    return base.CalculateInterest(months - 6);
                }
                else
                {
                    return this.Balance;
                }
            }
            else
            {
                if (months > 12 )
                {
                    return (this.Balance * (decimal)(1 + (this.InterestRate * 0.5) * 12)) + base.CalculateInterest(months - 12); 
                }
                return this.Balance * (decimal)(1 + (this.InterestRate * 0.5) * months);
            }
            
        }
    }
}
