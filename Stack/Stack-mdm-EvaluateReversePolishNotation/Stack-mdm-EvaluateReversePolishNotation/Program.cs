namespace Stack_mdm_EvaluateReversePolishNotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] tokens = new string[] { "4", "13", "5", "/", "+" };
            int result = solution.EvalRPN(tokens);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            foreach (string token in tokens)
            {
                switch (token)
                {
                    case "+":
                        stack.Push(stack.Pop() + stack.Pop());
                        break;
                    case "-":
                        int right = stack.Pop();
                        int left = stack.Pop();
                        stack.Push(left - right);
                        break;
                    case "*":
                        stack.Push(stack.Pop() * stack.Pop());
                        break;
                    case "/":
                        int denominator = stack.Pop();
                        int Numerator = stack.Pop();
                        stack.Push(Numerator / denominator);
                        break;
                    default:
                        stack.Push(int.Parse(token));
                        break;
                }
            }
            return stack.Pop();
        }
    }

}
