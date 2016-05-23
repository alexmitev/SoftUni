using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account : IinterestCalculatable, IDepositable
    {
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public double InterestRate { get; set; }

        public  Account(Customer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual decimal CalculateInterest(double months)
        {
            return this.Balance * (decimal)(1 + this.InterestRate * months);
        }

        public virtual void Deposit (decimal ammount)
        {
            this.Balance += ammount;
        }
    }
}
