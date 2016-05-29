using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediShop.Interfaces
{
    interface ISaleable
    {
        IItem Item { get;  }
        DateTime SaleDate { get; }
    }
}
