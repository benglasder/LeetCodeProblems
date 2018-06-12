using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class LeetCodeSolutions
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var hashTable = new Hashtable();

            for (var i = 0; i < nums.Length; i++)
            {
                int sum = target - nums[i];

                if (hashTable.ContainsKey(sum))
                {
                    Console.WriteLine($"Match Found: [{hashTable[sum]} , {i}]");
                    return new[] { (int)hashTable[sum], i };
                }

                if (!hashTable.ContainsKey(nums[i]))
                {
                    hashTable.Add(nums[i], i);
                }
            }

            throw new Exception("No solution");
        }
    }
}
