using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopping_trolley
{
    class Peach:Item
    {
        private static Peach instance;
        public static Peach Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Peach();
                   
                }

                return instance;
            }
        }
        public Peach()
        {
            itemname = "Peach";
            count = 100;
        }
    }
}
