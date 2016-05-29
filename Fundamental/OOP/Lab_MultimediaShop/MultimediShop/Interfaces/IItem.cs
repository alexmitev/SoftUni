using System;
using System.Collections.Generic;
using System.Linq;
using MultimediShop.Enums;

namespace MultimediShop.Interfaces
{
   public interface IItem
    {
         string Id { get; set; }
         string Title { get; set; }
         decimal Price { get; set; }
        List<String> Genres { get; set; }

    }
}
