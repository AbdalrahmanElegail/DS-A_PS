namespace Maths_Geometry_ez_PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] digits = [ 9, 9, 9 ];
            var result = s.PlusOne(digits);
            Console.WriteLine(string.Join(" ", result));
        }
    }

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            for(int i = digits.Length -1; i>=0; i--) 
            {
                if (digits[i] < 9) 
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }

}
