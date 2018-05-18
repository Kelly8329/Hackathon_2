using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hackathon05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon05.Tests
{
    [TestClass()]
    public class testTests
    {
        [TestMethod()]
        public void Given_Palindrome_When_Result_Then_True()
        {
            string expected = "是回文";
            var s1 = "12321";
            char[] array = s1.ToCharArray();
            Array.Reverse(array);
            var s2 = new string(array);
            var actual = test.decide(s1);
            Assert.AreEqual(expected, actual);

        }
    }
}