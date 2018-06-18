using System;
using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class MaxProfitTests
    {
        private readonly LeetCodeSolutions _leet = new LeetCodeSolutions();

        [TestMethod]
        public void SellOnDayFive()
        {
            var input = new int[] {7, 1, 5, 3, 6, 4};
            var expected = 5;

            Assert.IsTrue(_leet.MaxProfit(input).Equals(5));
        }
    }
}
