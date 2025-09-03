namespace Array_ez_ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "andd";
            string t = "dadd";
            Solution solution = new Solution();
            Console.WriteLine( solution.IsAnagram(s, t) );

        }
    }

    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char,int> freq = new Dictionary<char, int>();
            
            if (s.Length != t.Length) { return false; }

            foreach (char c in s)
            {
                if (freq.ContainsKey(c)) { freq[c]++; }
                else { freq[c] = 1; }
            }
            foreach (char c in t)
            {
                if (!freq.ContainsKey(c)) { return false; }
                if (freq.ContainsKey(c)) { freq[c]--; }
                if (freq[c] == 0) { freq.Remove(c); }
            }

            if (freq.Count == 0) { return true; }
            else return false;
        }
    }

}
