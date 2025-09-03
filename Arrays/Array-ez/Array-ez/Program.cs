using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_ez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 5, 4, 6 };
            Solution solution = new Solution();
            Console.WriteLine(solution.hasDuplicate(nums));

        }
    }

    public class Solution
    {
        public bool hasDuplicate(int[] nums)
        {

            HashSet<int> nums2 = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums2.Contains(nums[i])) { return true; } // duplicate found
                else { nums2.Add(nums[i]); }
            }
            return false;
        }
    }
}
