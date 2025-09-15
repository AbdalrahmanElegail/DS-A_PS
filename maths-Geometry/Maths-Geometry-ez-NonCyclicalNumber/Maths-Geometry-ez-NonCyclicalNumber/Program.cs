namespace Maths_Geometry_ez_NonCyclicalNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool result = solution.IsHappy(19);
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();
            while (n != 1) 
            {
                if (seen.Contains(n))
                {
                    return false;
                }
                seen.Add(n);
                n = GetResult(n);
            }
            return true;
        }
        public int GetResult(int n) 
        {
            int result = 0;
            while (n > 0) 
            {
                int digit = n % 10;
                n /= 10;
                result += digit*digit;
            }
            return result;
        }
    }
}
