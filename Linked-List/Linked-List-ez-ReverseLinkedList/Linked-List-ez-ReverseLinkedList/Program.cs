namespace Linked_List_ez_ReverseLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var res = solution.ReverseList(new ListNode { val = 5,  next = null });
            Console.WriteLine($"{res.val},{res.next}");
        }
    }
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode? prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                ListNode temp = curr.next;
                curr.next = prev!;
                prev = curr;
                curr = temp;
            }
            return prev!;
        }
    }

}
