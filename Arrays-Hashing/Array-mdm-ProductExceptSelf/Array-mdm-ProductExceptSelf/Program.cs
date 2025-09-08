using System.Reflection.Metadata;

namespace Array_mdm_ProductExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, -1, 0 };
            Solution solution = new Solution();
            int[] result = solution.ProductExceptSelf(nums);
            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }
    }
    
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int productForNonZero = 1;
            int productForZero = 1;
            int[] result = new int[nums.Length];
            if (hasDuplicatedZero(nums)) { return new int[nums.Length]; } // return array of zeros if duplicate found

            for (int i=0; i<nums.Length; i++ )
            {
                if (nums[i] == 0) 
                {
                    productForNonZero *= nums[i];
                    continue; 
                } // skip zero for product calculation

                productForNonZero *= nums[i];
                productForZero *= nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) { result[i] = productForZero; continue; } // skip zero for product calculation
                result[i] = productForNonZero / nums[i];
            }
            return result;
        }
        public bool hasDuplicatedZero(int[] nums)
        {

            HashSet<int> nums2 = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums2.Contains(nums[i])) 
                {
                    if (nums[i] == 0) { return true; } // duplicate zero found
                    else { continue; }
                } 
                else { nums2.Add(nums[i]); }
            }
            return false;
        }
    }

}
