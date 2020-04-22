using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopping_trolley
{
    using System;
    public interface ShoppingCart
    {
        void AddItems(Item anItem, int quantity);
        void DeleteItems(Item anItem, int quantity);
        int ItemCount { get; }
    }
}
