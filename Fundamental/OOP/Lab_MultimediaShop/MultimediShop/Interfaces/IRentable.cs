using System;
using MultimediShop.ModelClasses;

namespace MultimediShop.Interfaces
{
    interface IRentable
    {
        Item Item { get;  }
        DateTime DateOfRent { get; }
        DateTime DeadlineDate { get;}

       
        DateTime ReturnDate { get; }

        decimal RentFine();


    }
}
