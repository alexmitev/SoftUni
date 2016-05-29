using System;
using System.Collections.Generic;
using MultimediShop.Interfaces;
using MultimediShop.Enums;
using System.Text;

namespace MultimediShop.ModelClasses
{
    public abstract class Item : IItem
    {
        private string id;
        private List<string> genres;
        private string title;
        private decimal price;

        protected Item (string id, string title, decimal price, List<string> genres)
        {
            this.Id = id;
            this.Genres = genres;
            this.Title = title;
            this.Price = price;
        }
        protected Item (string id, string title, decimal price)
            : this(id, title, price, null)
        {

        }

        public List<string> Genres
        {
            get
            {
                return this.genres;
            }

            set
            {
                this.genres = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;

            }
           
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 4 )
                {
                    throw new ArgumentOutOfRangeException("ID is not in the correct format");
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be a negative number");
                }
                this.price = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Title cannot be empty");

                }
                this.title = value;
            }
        }
    }
}
