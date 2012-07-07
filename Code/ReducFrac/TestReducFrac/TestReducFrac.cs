using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReducFrac;

namespace TestFrac
{
    [TestClass]
    public class TestReducFrac
    {
        [TestMethod]
        public void TestUnDixieme()
        {
            Tuple<int, int> f = new Tuple<int, int>(1, 10);
            Assert.AreEqual<Tuple<int, int>>(ReducFrac.ReducFrac.Go(f), new Tuple<int, int>(1, 10));
        }
        [TestMethod]
        public void Test34vingtieme()
        {
            Tuple<int, int> f = new Tuple<int, int>(34, 20);
            Assert.AreEqual<Tuple<int, int>>(new Tuple<int, int>(17, 10), ReducFrac.ReducFrac.Go(f));
        }
    }
}
