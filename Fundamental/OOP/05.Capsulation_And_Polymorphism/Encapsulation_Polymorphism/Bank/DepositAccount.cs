using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class DepositAccount : Account, IWithdrawable
    {

        public DepositAccount(Customer customer, decimal balance, double interestRate ) 
            : base(customer, balance, interestRate)
        {
          
        }

        public override decimal CalculateInterest(double months)
        {

            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(months);
            }
            
        }

        public void Withdraw (decimal ammount)
        {
            this.Balance -= ammount;
        }
    }
}
