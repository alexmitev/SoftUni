using System;
using System.Collections.Generic;
using MultimediShop.Interfaces;
using MultimediShop.Enums;

namespace MultimediShop.ModelClasses
{
   public class Sale : ISaleable
    {
        private  IItem item;
        private DateTime saleDate;

        public Sale (Item item, DateTime saleDate)
        {
            this.Item = item;
            this.SaleDate = saleDate;
        }

        public Sale (Item item)
            : this(item, DateTime.Now)
        {

        }

        public DateTime SaleDate
        {
            get
            {
                return this.saleDate;
            }

            set
            {
                this.saleDate = value;
            }
        }

        public IItem Item
        {
            get
            {
                return this.item;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Item cannot be empty");
                }

                this.item = value;
            }
        }
    }
}
