using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool IsPalindrome(string s)
        {
            //empty string or 1 char string is valid
            if (s.Length < 2)
                return true;

            var rgx = new Regex("[^a-zA-Z0-9]");

            // use regex to replace non-alphanumeric and move to Upper
            s = rgx.Replace(s, "").ToUpper();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public int MyAtoi(string str)
        {
            // Assume val is positive to begin
            bool isPos = true;

            // first check for empty/null string
            if (str.Equals("") || str == string.Empty)
            {
                return 0;
            }

            // Trim all beginning whitespace
            str = str.TrimStart(' ');

            if (str[0] == '-')
            {
                // remove sign from string
                str = str.Substring(0);
                isPos = false;
            }
            else if (str[0] == '+')
            {
                str = str.Substring(0);
            }

            int result = int.Parse(str);

            return isPos ? result : (result * -1);

        }
    }
}
