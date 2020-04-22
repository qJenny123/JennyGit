using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace 堆栈
{
    [TestFixture]
    public class StackTest
    {
        Stack S;
        [SetUp]
        public void Init()
        {
            S = new Stack();
        }
        [Test]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void TestTop()
        {
            S.Top();
        }

        [Test]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void TestPop()
        {
            S.Push("1");
            S.Pop();
            Assert.AreEqual(0, S.stack.Count);
            S.Pop();
            S.stack.Clear();
        }


    }
}
