using System;
using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SpiralOrderTests
    {
        private readonly LeetCodeSolutions _leet = new LeetCodeSolutions();

        [TestMethod]
        public void ThreeByThree()
        {
            var input = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            var expected = new int[] {1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7};

            Assert.IsTrue(_leet.SpiralOrder(input).Equals(expected));
        }

        [TestMethod]
        public void FourByThree()
        {
            var input = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

            var expected = new int[] {1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7};

            Assert.IsTrue(_leet.SpiralOrder(input).Equals(expected));
        }
    }
}
