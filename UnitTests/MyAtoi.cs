using System;
using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class MyAtoi
    {
        [TestMethod]
        public void ReturnZero()
        {
            var leet = new LeetCodeSolutions();

            var str = "";

            Assert.IsTrue(leet.MyAtoi(str).Equals(0));

        }

        [TestMethod]
        public void FourtyTwo()
        {
            var leet = new LeetCodeSolutions();

            var str = "42";

            Assert.IsFalse(leet.MyAtoi(str).Equals(0));

            Assert.IsFalse(leet.MyAtoi(str).Equals(-42));

            Assert.IsTrue(leet.MyAtoi(str).Equals(42));
        }

        [TestMethod]
        public void FourtyTwoTrimSpace()
        {
            var leet = new LeetCodeSolutions();

            var str = "      -42";

            Assert.IsFalse(leet.MyAtoi(str).Equals(0));

            Assert.IsFalse(leet.MyAtoi(str).Equals(42));

            Assert.IsTrue(leet.MyAtoi(str).Equals(-42));
        }

        [TestMethod]
        public void FourOneNineThreeWithWords()
        {
            var leet = new LeetCodeSolutions();

            var str = "4193 with words";

            Assert.IsFalse(leet.MyAtoi(str).Equals(0));

            Assert.IsTrue(leet.MyAtoi(str).Equals(4193));
        }

        [TestMethod]
        public void NotValid()
        {
            var leet = new LeetCodeSolutions();

            var str = "words and 987";

            Assert.IsFalse(leet.MyAtoi(str).Equals(987));

            Assert.IsTrue(leet.MyAtoi(str).Equals(0));
        }

        [TestMethod]
        public void OutOfRange()
        {
            var leet = new LeetCodeSolutions();

            var str = "-91283472332";

            Assert.IsFalse(leet.MyAtoi(str).Equals(0));

            Assert.IsTrue(leet.MyAtoi(str).Equals(int.MinValue));
            Assert.IsTrue(leet.MyAtoi(str).Equals(-2147483648));
        }

    }
}
