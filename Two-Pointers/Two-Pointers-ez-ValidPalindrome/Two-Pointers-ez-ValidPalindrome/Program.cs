namespace Two_Pointers_ez_ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "Was it a car or a cat I saw";
            Console.WriteLine(solution.IsPalindrome(s));
        }
    }
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            int i=0, j=s.Length-1;
            while (i <= j)
            {
                if (s[i] == ' ' || !char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }
                if (s[j] == ' ' || !char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }
                if (char.ToLower(s[i]) != char.ToLower(s[j])) { return false; }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }
    }

}
