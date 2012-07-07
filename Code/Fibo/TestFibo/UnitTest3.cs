using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibo;

namespace TestFibo
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dictionary<int, int> a = new Dictionary<int, int>();
            a[0] = 0;
            a[1] = 1;
            a[2] = 1;

            foreach (KeyValuePair<int,int> v in a)
            {
                Assert.AreEqual(v.Value, Fibo.Fibo3.Go(v.Key));
            }
        }
    }
}
