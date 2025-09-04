using System.Diagnostics.Metrics;

namespace Array_mdm_GroupAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            Solution solution = new Solution();
            List<List<string>> result = solution.GroupAnagrams(strs);
            
            foreach (var group in result)
            {
                Console.WriteLine("[" + string.Join(", ", group) + "]");
            }
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>(); 

            foreach (string str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

               
                if (!map.ContainsKey(key))
                    map[key] = new List<string>();
                map[key].Add(str);

            }
            List<List<string>> result = map.Values.ToList();

            return result;
        }
    }

}
