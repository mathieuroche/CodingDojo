using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFibo
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dictionary<int, int> a = new Dictionary<int, int>();
            a[0] = 0;
            a[1] = 1;
            a[2] = 1;
            a[3] = 2;

            foreach (KeyValuePair<int, int> v in a)
            {
                Assert.AreEqual(v.Value, Fibo.Fibo4.Go(v.Key));
            }
        }
    }
}
