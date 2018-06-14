using System;
using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class MyAtoi2
    {
        private readonly LeetCodeSolutions _leet = new LeetCodeSolutions();

        [TestMethod]
        public void ReturnZero()
        {

            var str = "";

            Assert.IsTrue(_leet.MyAtoi2(str).Equals(0));

        }

        [TestMethod]
        public void FourtyTwo()
        {

            var str = "42";

            Assert.IsFalse(_leet.MyAtoi2(str).Equals(0));

            Assert.IsFalse(_leet.MyAtoi2(str).Equals(-42));

            Assert.IsTrue(_leet.MyAtoi2(str).Equals(42));
        }

        [TestMethod]
        public void FourtyTwoTrimSpace()
        {

            var str = "      -42";

            Assert.IsFalse(_leet.MyAtoi2(str).Equals(0));

            Assert.IsFalse(_leet.MyAtoi2(str).Equals(42));

            Assert.IsTrue(_leet.MyAtoi2(str).Equals(-42));
        }

        [TestMethod]
        public void FourOneNineThreeWithWords()
        {

            var str = "4193 with words";

            Assert.IsFalse(_leet.MyAtoi2(str).Equals(0));

            Assert.IsTrue(_leet.MyAtoi2(str).Equals(4193));
        }

        [TestMethod]
        public void NotValid()
        {

            var str = "words and 987";

            Assert.IsFalse(_leet.MyAtoi2(str).Equals(987));

            Assert.IsTrue(_leet.MyAtoi2(str).Equals(0));
        }

        [TestMethod]
        public void OutOfRange()
        {

            var str = "-91283472332";

            Assert.IsFalse(_leet.MyAtoi2(str).Equals(0));

            Assert.IsTrue(_leet.MyAtoi2(str).Equals(int.MinValue));
            Assert.IsTrue(_leet.MyAtoi2(str).Equals(-2147483648));
        }

        [TestMethod]
        public void OnlyEmptySpaces()
        {
            var str = " ";

            Assert.IsTrue(_leet.MyAtoi2(str).Equals(0));

            str = "         ";
            Assert.IsTrue(_leet.MyAtoi2(str).Equals(0));
        }

        [TestMethod]
        public void PlusOrMinusOnly()
        {
            var str = "+";

            Assert.IsTrue(_leet.MyAtoi2(str).Equals(0));

            str = "-";
            Assert.IsTrue(_leet.MyAtoi2(str).Equals(0));
        }

        [TestMethod]
        public void PlusOne()
        {
            var str = "+1";
            Assert.IsTrue(_leet.MyAtoi2(str).Equals(1));
        }
    }
}
