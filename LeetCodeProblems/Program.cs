using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] {2, 7, 11, 15};

            var solution = TwoSum(nums, 9);

            Console.WriteLine(solution);

            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var hashTable = new Hashtable();

            for (var i = 0; i < nums.Length; i++)
            {
                int sum = target - nums[i];

                if (hashTable.ContainsKey(sum))
                {
                    return new[] {(int) hashTable[sum], i};
                }
                hashTable.Add(nums[i], i);
            }

            throw new Exception("No solution");
        }

    }
}
