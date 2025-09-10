 namespace Stack_mdm_MinimumStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(0);
            minStack.Push(3);
            minStack.Push(-2);
            Console.WriteLine(minStack.GetMin()); // return -2
            minStack.Pop();
            Console.WriteLine(minStack.GetMin());    // return 0
            minStack.Pop();
            Console.WriteLine(minStack.GetMin());
            minStack.Pop();
            Console.WriteLine(minStack.GetMin());       // return 2
            minStack.Pop();
            Console.WriteLine(minStack.GetMin());    // return 1
        }
    }

    public class MinStack
    {
        private readonly Stack<int> stack;
        private readonly Stack<int> minStack;
     
        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
            minStack.Push(minStack.Count == 0 ? val : Math.Min(val, minStack.Peek()));
        }

        public void Pop() {stack.Pop(); minStack.Pop();}

        public int Top() => stack.Peek();

        public int GetMin() => minStack.Peek();
    }

}
