using System;
using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ValidPalindrome
    {
        LeetCodeSolutions leet = new LeetCodeSolutions();

        [TestMethod]
        public void IsRacecarValidPalindrome()
        {
            Assert.IsTrue(leet.IsPalindrome("racecar"));
        }

        [TestMethod]
        public void IsVisualStudioValidPalindrome()
        {
            Assert.IsFalse(leet.IsPalindrome("Visual Studio"));
        }

        [TestMethod]
        public void AManAPlanACanalPanama()
        {
            Assert.IsTrue(leet.IsPalindrome("A man, a plan, a canal: Panama"));
        }
    }
}
