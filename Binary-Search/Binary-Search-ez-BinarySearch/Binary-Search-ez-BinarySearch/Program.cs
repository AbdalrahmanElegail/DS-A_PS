using System.Threading.Channels;

namespace Binary_Search_ez_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = [-1, 0, 2, 4, 6, 8];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine(solution.Search(nums,int.Parse(Console.ReadLine()!)));
            }
        }
    }
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int r = nums.Length-1;
            int l = 0;
            int i = l + (r-l) / 2;
            while (r >= l)
            {
                i = l + (r - l) / 2;
                if (target == nums[i]) return i;
                else if (target > nums[i]) l = i+1;
                else  r = i-1;
            }
            return -1;
        }
    }
}
