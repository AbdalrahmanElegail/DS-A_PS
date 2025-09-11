namespace Two_Pointers_mdm_TwoIntegerSumII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] result = solution.TwoSum(new int[] { 2,4   ,8,10,11,12, 15 }, 13);
            Console.WriteLine($"{result[0]} , {result[1]}");
        }
    }
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int i = 0, j = numbers.Length - 1;
            for (; i < j;)
            {
                int sum = numbers[i] + numbers[j];
                if (sum < target) i++;
                else if (sum > target) j--;
                else break;
            }
            return new int[] {i + 1, j + 1};
        }
    }

}
