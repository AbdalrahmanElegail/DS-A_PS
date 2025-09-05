namespace Array_mdm_EncodeAndDecodeStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strs = new List<string> {};
            Solution solution = new();
            string? encoded = solution.Encode(strs);
            List<string>? refactored = solution.Decode(encoded);

            Console.WriteLine(string.Join("",refactored));

        }
    }


    public class Solution
    {

        public string? Encode(IList<string> strs)
        {
            if (strs.Count == 0) {  return null; }

            string result = string.Join('"', strs);
            return result;
        }

        public List<string>? Decode(string s)
        {
            if (s==null) return new List<string> { };

            List<string> result = s.Split('"').ToList();
            return result;
        }
    }

}
