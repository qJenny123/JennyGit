using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopping_trolley
{
    class Pear:Item
    {
        private static Pear instance;
        public static Pear Instance
        {
            get
            {
                if (instance == null)
                {
                    instance= new Pear();
                }
               
                    return instance;
                
            }
        }
        public Pear()
        {
            itemname = "Pear";
            count = 100;
        }
       
    }
}
