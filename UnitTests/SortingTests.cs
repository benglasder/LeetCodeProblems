using System;
using System.Linq;
using System.Text;
using LeetCodeEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SortingTests
    {
        SortMethods _sort = new SortMethods();

        [TestMethod]
        public void BubbleSortInOrder()
        {
            var startTime = DateTime.Now;
            var input = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
            var expected = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
            var result = _sort.BubbleSort(input);

            var endTime = DateTime.Now;
            
            Console.WriteLine($"Runtime: {(endTime - startTime).Milliseconds.ToString()}");
            
            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [TestMethod]
        public void BubbleSortPartiallyOutOfOrder()
        {
            var startTime = DateTime.Now;
            var input = new int[]    {7, 2, 3, 4, 5, 6, 1, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
            var expected = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
            var result = _sort.BubbleSort(input);

            var endTime = DateTime.Now;


            var evenNumbers = expected.Where(n => n % 2 == 0).ToList();
            
            Console.WriteLine($"Runtime: {(endTime - startTime).Milliseconds.ToString()}");
            
            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [TestMethod]
        public void Tests()
        {
            var expected = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};

            var evenNumbers = expected.Where(n => n % 2 == 0).ToList();

            var str = "ABCDEFG";
            var sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            Console.WriteLine(sb.ToString());
        }
       
    }
}