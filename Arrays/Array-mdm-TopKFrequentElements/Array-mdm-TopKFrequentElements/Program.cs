namespace Array_mdm_TopKFrequentElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums = { 1, 2 };
            int k = 2;
            Solution solution = new Solution();
            int[] result = solution.TopKFrequent(nums, k);
            Console.WriteLine(string.Join(", ", result));
        }
    }
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                    frequencyMap[num]++;
                else
                    frequencyMap[num] = 1;
            }

            int[] result = frequencyMap
                                .OrderByDescending(x => x.Value)
                                .Take(k)
                                .Select(x => x.Key)
                                .ToArray();

            return result;
        }
    }
}
