namespace Array_ez_TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 5, 6 };
            int target = 10;
            Solution solution = new Solution();
            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine($"{string.Join(", ", result)}");

        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int j = Array.IndexOf(nums, (target - nums[i]));

                if (j >= 0 && i != j)
                {
                    return new int[] { j, i };
                }
            }
            return new int[0];
        }
    }
}
