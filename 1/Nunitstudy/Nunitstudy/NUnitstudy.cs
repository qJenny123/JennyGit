using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using NUnit.Framework;

namespace Nunitstudy
{
    [TestFixture]
    public class NumersFixture
    {
        [Test]
        public void AddTwoNumbers()
        {
            int a = 1;
            int b = 2;
            int c = a * b;
            Assert.AreEqual(c, 2);
        }
    }

}
