using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Fax
{
    [TestFixture]
    class FaxTest
    {
        [Test]
        public void SendFaxTest()
        {
            Fax fax = new Fax();
            bool result = fax.SendFax("371-000-0000", "123456");
            Assert.AreEqual(true, result);
        }
    }
}
