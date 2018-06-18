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

        [TestMethod]
        public void TheSkyIsBlue()
        {
            var str = "the sky is blue";
            var expected = "blue is sky the";

            Assert.IsTrue(_leet.ReverseWords(str).Equals(expected));
        }

        [TestMethod]
        public void ExtraSpaces()
        {
            var str = "  the sky  is blue  ";
            var expected = "blue is sky the";

            Assert.IsTrue(_leet.ReverseWords(str).Equals(expected));
        }

        [TestMethod]
        public void EmptyString()
        {
            var str = "";
            var expected = "";

            Assert.IsTrue(_leet.ReverseWords(str).Equals(expected));
        }

        [TestMethod]
        public void AllSpaces()
        {
            var str = "                      ";
            var expected = "";

            Assert.IsTrue(_leet.ReverseWords(str).Equals(expected));
        }

        [TestMethod]
        public void ArrayOfChars()
        {
            var str = new[]{'t', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e'};

            _leet.ReverseWords(str);
        }
    }
}