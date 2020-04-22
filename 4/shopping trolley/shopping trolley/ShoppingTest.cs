using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace shopping_trolley
{
    [TestFixture]
    class ShoppingTest
    {
        [Test]
        public void AddItemsTest()
        {
            int quanitity = 100;
            Shopping.Instance.AddItems(Pear.Instance, quanitity);
            Assert.AreEqual(true, Pear.Instance.count >= 0);

        }

        [Test]
        public void DeleteItemsTest()
        {
            int add_quanitity = 100;
            Shopping.Instance.AddItems(Peach.Instance, add_quanitity);
            Assert.AreEqual(true, Peach.Instance.count >= 0);

            int delete_quanitity = 100;
            Shopping.Instance.DeleteItems(Peach.Instance, delete_quanitity);
            Assert.AreEqual(true, Shopping.Instance.PeachCount >= 0);

        }
    }
}
