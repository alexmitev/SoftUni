using System;
using System.Collections.Generic;
using MultimediShop.Interfaces;
using MultimediShop.Enums;

namespace MultimediShop.ModelClasses
{
     public class Rent : IRentable
    {

        private Item item;
        private DateTime dateOfRent;
        private DateTime deadlineDate;
        private DateTime returnDate;
        private RentState rentState;


        public Rent (Item item, DateTime  dateOfRent, DateTime deadlineDate)
        {
            this.Item = item;
            this.DateOfRent = dateOfRent;
            this.DeadlineDate = deadlineDate;
          
        }
        public Rent(Item item, DateTime dateOfRent)
            : this(item, dateOfRent, dateOfRent.AddDays(30))
        {

        }
        public Rent (Item item)
            : this(item, DateTime.Now)
        {

        }

        public DateTime DateOfRent
        {
            get
            {
                return this.dateOfRent;
            }

            set
            {
                this.dateOfRent = value;
            }
        }

        public DateTime ReturnDate
        {
            get
            {
                return this.returnDate;
            }

         
        }

        public DateTime DeadlineDate
        {
            get
            {
                return this.deadlineDate;
            }

            set
            {
                this.deadlineDate = value;
            }
        }

        public Item Item
        {
            get
            {
                return this.item;
            }

           private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Item cannot be empty");
                }
                this.item = value;
            }
        }

        public RentState RentState
        {
            get
            {
                return this.GetRentState();
            }

             private set
            {
                this.rentState = value;
            }
        }

        public decimal RentFine()
        {
            
                DateTime date = this.ReturnDate.Year > 1 ? this.ReturnDate : DateTime.Now;

            int overdueDays = (date - this.deadlineDate).Days;

                return Math.Max((overdueDays  * this.Item.Price * 0.01m), 0);
          
        }

        private RentState GetRentState()
        {
            if (this.rentState == RentState.Returned)

            {
                return RentState.Returned;
            }
           else if (DateTime.Today <= this.DeadlineDate)
            {
                return RentState.Pending;
            }

            return RentState.Overdue;
        }

        public void ReturnItem()
        {
            this.rentState = RentState.Returned;
            this.returnDate = DateTime.Today;
        }
    }
}
