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
        /// <summary>
        ///  My First Attempt
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int MyAtoi(string str)
        {
            // Assume val is positive to begin
            bool isPos = true;

            // first check for empty/null string
            if (str.Equals("") || str == string.Empty)
            {
                Console.WriteLine($"Input: {str} | Output: 0");
                return 0;
            }

            // Trim all beginning whitespace
            str = str.TrimStart(' ');
            if (str.Equals(""))
            {
                Console.WriteLine($"Input: {str} | Output: 0");
                return 0;
            }


            if (str.Length > 1)
            {
                if (str[0] == '-')
                {
                    // remove sign from string
                    str = str.Substring(1);
                    isPos = false;
                }
                else if (str[0] == '+')
                {
                    str = str.Substring(1);
                }
            }

            if (!int.TryParse(str[0].ToString(), out _))
            {
                Console.WriteLine($"Input: {str} | Output: 0");
                return 0;
            }

            // create temporary array to hold individual ints to add up later
            int[] chars = new int[str.Length];

            int length = 0;
            for (int i = 0; i < str.Length; i++)
            {
                
                // Try parsing int, if int, add. If not, we reached the end
                if (int.TryParse(str[i].ToString(), out int res))
                {
                    length++;
                    chars[i] = res;
                }
                else
                {
                    // Create new smaller array
                    int[] temp = new int[length];
                    for (int x = 0; x < length; x++)
                    {
                        temp[x] = chars[x];
                    }

                    chars = temp;
                    break;
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (int i in chars)
            {
                sb.Append(i);
            }

            var success = int.TryParse(sb.ToString(), out int result);

            if (success)
            {
                Console.WriteLine($"Input: {str} | Output: {result}");
                return isPos ? result : (result * -1);
            }

            Console.WriteLine($"Input: {str} | Output: {result}");
            return isPos ? int.MaxValue : int.MinValue;

        }
        
        /// <summary>
        /// LeetCode top answer
        /// Initially failed 'OnlyEmptySpaces' Test.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int MyAtoi2(string str)
        {
        
            int sign = 1; // Will be either 1 or -1
            int baseX = 0; // our base number
            int i = 0;
            if (str.Length <= 0)
            {
                Console.WriteLine($"Input: {str} | Output: 0");
                return 0;
            }
            str = str.Trim();
            // Add check for empty string (All spaces)
            if (!str.Equals("") && (str[i] == '-' || str[i] == '+'))
            {
                // If - exits, subtract 2 from 1 to get -1
                sign = 1 - 2 * (str[i++] == '-' ? 1 : 0);
            }
            // Loop through the array of chars until the end, or we reach a char that isnt numeric
            while (i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
               // Console.WriteLine($"{str[i]} | ++ {str[i++]}");
                if (baseX > Int32.MaxValue / 10 || (baseX == Int32.MaxValue / 10 && str[i] - '0' > 7))
                {
                    if (sign == 1)
                    {
                        Console.WriteLine($"Input: {str} | Output: {Int32.MaxValue} (Max)");
                        return Int32.MaxValue;
                    }
                    else
                    {
                        Console.WriteLine($"Input: {str} | Output: {Int32.MinValue} (Min)");
                        return Int32.MinValue;
                    }
                }

                baseX = 10 * baseX + (str[i++] - '0');
            }
           // Console.WriteLine($"Input: {str} | Output: {baseX * sign}");
            return baseX * sign;
        }
    }
}
