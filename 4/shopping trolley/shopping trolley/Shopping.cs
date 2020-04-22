using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopping_trolley
{
    public class Shopping:ShoppingCart
    {
        private static Shopping instance;
        public static Shopping Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Shopping();
                }
                return instance;
             }
        }
        public int PearCount;
        public int PeachCount;
        public Shopping()
        {
            PearCount = 0;
            PeachCount = 0;
        }
        public void AddItems(Item anItem, int quantity)
        {
            if (anItem.itemname == "Pear")
            {
                Pear.Instance.count -= quantity;
                PearCount += quantity;
            }
            else if (anItem.itemname == "Peach")
            {
                Peach.Instance.count -= quantity;
                PeachCount += quantity;
            }
        }
        public void DeleteItems(Item anItem, int quanitity)
        {

            if (anItem.itemname == "Apple")
            {
                Pear.Instance.count += quanitity;
                PearCount -= quanitity;
            }
            else if (anItem.itemname == "Banana")
            {
                Peach.Instance.count += quanitity;
                PeachCount -= quanitity;
            }
        }

        public int ItemCount
        {
            get
            {
                return PearCount + PeachCount;
            }
        }
    }
}
