using System;
using System.Collections.Generic;
using System.Linq;
using MultimediShop.Enums;

namespace MultimediShop.ModelClasses
{
    class Game : Item
    {

        private AgeRestriction agerestriction;

        public Game(string id, string title, decimal price, List<string> genres, AgeRestriction agerestriction = AgeRestriction.Minor) : base (id, title, price, genres)
        {
            this.Agerestriction = agerestriction;
        }

        public Game(string id, string title, decimal price, string genre, AgeRestriction agerestriction = AgeRestriction.Minor)
            : this(id, title, price, new List<string>() { genre },agerestriction)
        {

        }

        public AgeRestriction Agerestriction
        {
            get
            {
                return this.agerestriction;
            }

            set
            {
                this.agerestriction = value;
            }
        }
    }
}
