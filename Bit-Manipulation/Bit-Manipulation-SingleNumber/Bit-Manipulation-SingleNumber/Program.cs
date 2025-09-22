namespace Bit_Manipulation_SingleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 4, 1, 2, 1, 2 };
            int result = solution.SingleNumber(nums);
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }

}
