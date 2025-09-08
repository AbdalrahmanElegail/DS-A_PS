namespace Stack_ez_ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string input = "}";
            bool result = solution.IsValid(input);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> chars = new Stack<char>();
            foreach (char c in s)
            {
                if(c == '{' || c == '[' || c == '(')
                    chars.Push(c); 
                else if ( chars.Count != 0 && c == '}' && chars.Peek() == '{' ||
                          chars.Count != 0 && c == ']' && chars.Peek() == '[' ||
                          chars.Count != 0 && c == ')' && chars.Peek() == '(' )
                    chars.Pop();
                else
                    return false;
            }
            return chars.Count == 0 ? true : false;
        }
    }


}
