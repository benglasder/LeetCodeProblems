using System;
using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ReverseString
    {
        private readonly LeetCodeSolutions _leet = new LeetCodeSolutions();

        [TestMethod]
        public void HelloOlleh()
        {
            var str = "hello";
            var expected = "olleh";

            Assert.IsTrue(_leet.ReverseString(str).Equals(expected));
        }
    }
}
