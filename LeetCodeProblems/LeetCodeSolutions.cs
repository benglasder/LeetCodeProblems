﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LeetCodeEntities.Trees;

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
            return baseX * sign;
        }

        public string ReverseString(string s)
        {
            var result = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                result.Append(s[i]);
            }

            Console.WriteLine($"Input: {s} | Output: {result}");
            return result.ToString();
        }

        public string ReverseWords(string s)
        {
            var sb = new StringBuilder();
            var delimiter = ' ';

            var words = s.Split(delimiter);

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (!words[i].Equals(""))
                {
                    sb.Append($"{words[i]} ");
                }
            }

            // Remove last space
            var result = sb.ToString() == "" ? "" : sb.ToString().Remove(sb.Length - 1);

            Console.WriteLine($"Input:  '{s}'");
            Console.WriteLine($"Output: '{result}'");
            return result;
        }

        public void ReverseWords(char[] str)
        {
            foreach (var c in str)
            {
                Console.Write(c);
            }

            int start = 0;
            for (int end = 0; end < str.Length; end++)
            {
                // Reverse each word
                while (end < str.Length && str[end] != ' ')
                    // Change 'end' index after each found space char
                    end++;
                // Reverse the word, ending index being before the space of the next word
                Reverse(str, start, end - 1);
                Console.WriteLine("");
                foreach (var c in str)
                {
                    Console.Write(c);
                }
                // Done with first word, move to the next word
                start = end + 1;
            }
            // Reverse the entire array
            Reverse(str, 0, str.Length - 1);
            Console.WriteLine("");
            foreach (var c in str)
            {
                Console.Write(c);
            }
        }

        private void Reverse(char[] s, int start, int end)
        {
            while (start < end)
            {
                var temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;
            }
        }

        public void Pyramid(int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine("");
            }

            
        }

        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }

            int max = 0;
            int currMin = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > currMin)
                {
                    Console.WriteLine($"{prices[i]} is greater than the current minimum of {currMin}");
                    
                    max = Math.Max(max, prices[i] - currMin);
                    Console.WriteLine($"New maximum is {max}");
                }
                else
                {
                    Console.WriteLine($"Current minimum is now {prices[i]}");
                    currMin = prices[i];
                }
            }

            return max;
        }

        public static IEnumerable<int> SpiralOrder(int[,] matrix)
        {

            IList<int> result = new List<int>();           
            int top = 0; // starting row index
            int bottom = matrix.GetLength(0); // ending row index
            int left = 0; // starting column index
            int right = matrix.GetLength(1); // ending column index

            while (result.Count() < matrix.Length)
            {
                // Print first row 
                for (int i = left; i < right; i++)
                {
                    result.Add(matrix[top,i]);
                }

                top++;

                for (int i = top; i < bottom; i++)
                {
                    result.Add(matrix[i, right - 1]);
                }

                right--;

                if (result.Count() < matrix.Length)
                {
                    for (int i = right - 1; i >= left; i--)
                    {
                        result.Add(matrix[bottom - 1, i]);
                    }

                    bottom--;
                }

                if (result.Count() < matrix.Length)
                {
                    for (int i = bottom - 1; i >= top; i--)
                    {
                        result.Add(matrix[i, left]);
                    }

                    left++;
                }

            }

            return result;

        }

        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, int.MinValue, int.MaxValue);
        }

        private bool IsValidBST(TreeNode root, int min, int max)
        {
            if (root != null)
            {
                Console.WriteLine($"Current Node: ({root.val})");
            }
            if (root == null)
            {
                Console.WriteLine("Node is Null. Return True");
                return true;
            }

            if (root.val >= max || root.val <= min)
            {
                if (root.val >= max)
                {
                    Console.WriteLine($"Node ({root.val}) is larger than the max value of {max}. Return False");
                }
                
                if (root.val <= min)
                {
                    Console.WriteLine($"Node ({root.val}) is smaller than the min value of {min}. Return False");
                }
                return false;
            }
            return IsValidBST(root.left, min, root.val) && IsValidBST(root.right, root.val, max);

        }

        public List<List<int>> LevelOrder(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<List<int>> wrapList = new List<List<int>>();

            if (root == null) return wrapList;
            
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int levelNum = queue.Count;
                List<int> subList = new List<int>();

                for (int i = 0; i < levelNum; i++)
                {
                    if(queue.Peek().left != null)
                        queue.Enqueue(queue.Peek().left);
                    if(queue.Peek().right != null)
                        queue.Enqueue(queue.Peek().right);
                    subList.Add(queue.Dequeue().val);
                }
                wrapList.Add(subList);
            }

            return wrapList;
        }
        
        public int CountPrimes(int n) {
            List<int> allNumbers = new List<int>();
            int count = 0;
            for(int i = 1; i < n; i++){
                allNumbers.Add(i);
            }
        
            foreach(var num in allNumbers)
            {
                if (isPrime(num))
                {
                    Console.WriteLine($"{num} is prime.");
                    count++;
                }
                    
            }
        
            return count;
        
        }

        private bool isPrime(int n)
        {
            if (n % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
                
            }

            return true;
        }
        
        
    }
}
