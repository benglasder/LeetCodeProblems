using System;
using System.Collections;
using System.Linq;
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

            var expected = new int[] {1, 2, 3, 6, 9, 8, 7, 4, 5, 6};

            var result = _leet.SpiralPrint(input).ToArray();
            
            Console.WriteLine("Expected:");
            foreach (var num in expected)
            {
                Console.Write($"{num} ");
            }
            
            Console.WriteLine();

            Console.WriteLine("Result:");
            foreach (var num in result)
            {
                Console.Write($"{num} ");
            }

            Assert.IsTrue(expected.SequenceEqual(result));
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

            var result = _leet.SpiralPrint(input).ToArray();
            
            Console.WriteLine("Expected:");
            foreach (var num in expected)
            {
                Console.Write($"{num} ");
            }
            
            Console.WriteLine();

            Console.WriteLine("Result:");
            foreach (var num in result)
            {
                Console.Write($"{num} ");
            }

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [TestMethod]
        public void OneTwoThreeFour()
        {
            var input = new int[,]
            {
                {1, 2},
                {3, 4}
            };

            var expected = new int[] {1, 2, 4, 3};

            var result = _leet.SpiralPrint(input).ToArray();
            
            Console.WriteLine("Expected:");
            foreach (var num in expected)
            {
                Console.Write($"{num} ");
            }
            
            Console.WriteLine();

            Console.WriteLine("Result:");
            foreach (var num in result)
            {
                Console.Write($"{num} ");
            }

            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}
