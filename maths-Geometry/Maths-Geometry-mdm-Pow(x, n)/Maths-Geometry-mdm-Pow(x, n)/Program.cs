namespace Maths_Geometry_mdm_Pow_x__n_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            double x = 2;
            int n = 8;
            double result = solution.MyPow(x, n);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public double MyPow(double x, int n)
        {
            double result = 1;
            double sub_result = x;
            int sub_n = n;
            if (n < 0) sub_n = -n;

            for (int i = 1; i <= sub_n; )
            {
                if (i <= sub_n / 2)
                {
                    sub_result *= sub_result;
                    i *= 2;
                }
                else
                {
                    result *= sub_result;
                    sub_n -= i;
                    i = 1;
                    sub_result = x;
                }
            }

            if (n == 0) { return 1; }
            else if (n < 0) 
            {
                return 1 / result;
            }
            else 
            {
                return result;
            }
        }
    }

}
