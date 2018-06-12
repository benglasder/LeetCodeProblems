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
            var leet = new LeetCodeSolutions();

            var nums = new[] {2, 7, 11, 15};

            var result = leet.TwoSum(nums, 9);

            Console.WriteLine(result);

            Console.ReadKey();
        }

    }
}
