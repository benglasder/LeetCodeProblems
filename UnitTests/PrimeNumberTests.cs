using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class PrimeNumberTests
    {
        private readonly LeetCodeSolutions _leet = new LeetCodeSolutions();

        [TestMethod]
        public void FourPrimeNumbersWithinTen()
        {
            int expected = 4;
            Assert.IsTrue(_leet.CountPrimes(10) == expected);
        }
    }
}