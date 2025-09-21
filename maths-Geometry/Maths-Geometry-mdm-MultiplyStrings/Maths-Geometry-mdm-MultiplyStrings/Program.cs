namespace Maths_Geometry_mdm_MultiplyStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string num1 = "12300000000000000000000000000000" , num2 = "45600000000000000000000000000000";
            string result = solution.Multiply(num1, num2);
            Console.WriteLine(result);
        }
    }


    // Solution Using BigInteger datatype ==>  Time: O(max(n,m)^2)  Space: O(max(n,m))
    public class Solution
    {
        public string Multiply(string num1, string num2)
        {
            (int n1, int n2) = GetIntegers(num1, num2);

            string result = GetString(n1*n2);

            return result;
        }

        private (int, int) GetIntegers(string num1, string num2) 
        {
            int n1=0, n2=0;
            foreach (char i in num1)
            {
                n1 *= 10;
                n1 += i - '0';
            }
            foreach (char i in num2)
            {
                n2 *= 10;
                n2 += i - '0';
            }
            return (n1, n2);
        }
        private string GetString(int num)
        {
            int digitsNum = 0, n=num;
            while (n > 0)
            {
                n /= 10;
                digitsNum++;
            }

            char[] resultChar = new char[digitsNum];
            for (int i = digitsNum-1; i >= 0; i--) 
            { 
                int temp = num % 10;
                num /= 10;
                resultChar[i] = (char)(temp + '0');
            }


            return new string(resultChar);
        }
    }
}
