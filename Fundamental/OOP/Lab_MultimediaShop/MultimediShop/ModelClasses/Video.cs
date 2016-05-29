using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediShop.ModelClasses
{
    class Video : Item
    {
        private double length;

        public Video (string id, string title, decimal price, double length, List<string> genres)
            : base(id,title, price, genres)
        {
            this.Length = length;
        }

        public Video(string id, string title, decimal price, double length, string genre)
            : this(id, title, price, length, new List<string>() { genre })
        {

        }

        public double Length
        {
            get
            {
                return this.length;
            }

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Lenght must be greater than 0");
                }
                this.length = value;
            }
        }
    }
}
