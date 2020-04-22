using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MyFirstTest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void plusTest()
        {
            Program pro = new Program();
            int result = pro.plus(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}
