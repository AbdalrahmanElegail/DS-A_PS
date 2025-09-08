namespace Array_mdm_LongestConsecutiveSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new int[] {  4, 1, 3, 2,201,202,203,204,205,206, 11,12,1,13,15,16,17,18 };
            int result = solution.LongestConsecutive(nums);
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            int result = 0;
            int current = 0;

            List<int> snums = CountingSort(nums).ToList();
            snums = RemoveDuplicates(snums); ;


            if (snums.Count == 0) return 0;
            if (snums.Count == 1) return 1;
            current = 1;

            for (int i = 1; i < snums.Count; i++)
            {
                if (snums[i] == snums[i - 1] + 1)
                {
                    current++;
                }
                else
                {
                    result = Math.Max(result, current);
                    current = 1;
                }
            }
            result = Math.Max(result, current);

            return result;
        }

        public int[] CountingSort(int[] nums)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (var num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            int range = max - min + 1;
            int[] count = new int[range];
            int[] output = new int[nums.Length];
            foreach (var num in nums)
            {
                count[num - min]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                output[count[nums[i] - min] - 1] = nums[i];
                count[nums[i] - min]--;
            }
            return output;
        }
        public List<int> RemoveDuplicates(List<int> nums)
        {
            if (nums.Count == 0) return nums;
            int j = 0;
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] != nums[j])
                {
                    j++;
                    nums[j] = nums[i];
                }
            }
            return nums.Take(j + 1).ToList();
        }
    }
}
