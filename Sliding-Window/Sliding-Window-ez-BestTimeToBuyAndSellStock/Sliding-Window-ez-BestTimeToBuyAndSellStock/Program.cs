namespace Sliding_Window_ez_BestTimeToBuyAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] prices = [3, 2, 5, 6, 15, 5 ,1,4,5,6,7,8,6,5,10,11];
            solution.MaxProfit(prices);
        }
    }
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int l = 0, r = 0, maxPrice = 0;

            while (r < prices.Length)
            {
                if (prices[r] > prices[l])
                    maxPrice = Math.Max(maxPrice, prices[r] - prices[l]);
                else
                    l = r;
                r++;
            }

            return maxPrice;
        }
    }

}
