using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediShop.ModelClasses
{
    class Book : Item
    {
        private string author;

        public Book (string id, string title, decimal price, string author, List<string> genres)
            : base(id, title, price, genres)
        {
            this.Author = author;
        }
        public Book(string id, string title, decimal price, string author, string genre)
            : this(id, title, price, author, new List<string>() { genre })
        {
            
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Author cannot be empty and must be at least 3 symbols long");
                }
                author = value;
            }
        }
    }
}
