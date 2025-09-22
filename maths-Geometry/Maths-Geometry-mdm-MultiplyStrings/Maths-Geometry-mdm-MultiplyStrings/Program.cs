namespace Maths_Geometry_mdm_MultiplyStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string num1 = "1230000000000000000000000000000000000000000000000000", num2 = "45600000000000000000000000000000";
            string result = solution.Multiply(num1, num2);
            Console.WriteLine(result);
        }
    }


    // Using Grade-school multiplication ==>  Time: O(n*m)  Space: O(n+m)
    public class Solution
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            int n = num1.Length, m = num2.Length;

            int[] result = new int[n + m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i + j] += (num1[n - i - 1] - '0') * (num2[m - j - 1] - '0');
                    result[i + j + 1] += result[i + j] / 10;
                    result[i + j] %= 10;
                }
            }

            if (result[^1] == 0)
                return string.Join("", result.Reverse().Skip(1));
            else
                return string.Join("", result.Reverse());
        }
    }
}
