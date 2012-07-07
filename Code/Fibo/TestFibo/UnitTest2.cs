using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibo;

namespace TestFibo
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, Fibo.Fibo2.Go(0));
            Assert.AreEqual(1, Fibo.Fibo2.Go(1));
        }
    }
}
