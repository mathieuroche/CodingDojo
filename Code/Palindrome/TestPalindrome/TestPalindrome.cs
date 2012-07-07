using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace PalindromeTest
{
    [TestClass]
    public class TestPalindrome
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Palindrome.Palindrome.IsPalindrome("laval"));            
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(Palindrome.Palindrome.IsPalindrome("lavol"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(Palindrome.Palindrome.IsPalindrome("Laval"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(Palindrome.Palindrome.IsPalindrome("laval"));
        }
        [TestMethod]
        public void TestMethodMajuscule()
        {
            Assert.IsTrue(Palindrome.Palindrome.IsPalindrome("ELLE"));
        }
        [TestMethod]
        public void TestMethodMixCase()
        {
            Assert.IsTrue(Palindrome.Palindrome.IsPalindrome("elLe"));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsFalse(Palindrome.Palindrome.IsPalindrome("etè"));
        }
    }
}
