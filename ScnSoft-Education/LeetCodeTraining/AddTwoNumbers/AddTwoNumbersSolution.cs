namespace LeetCodeTraining.AddTwoNumbers
{
    //https://leetcode.com/problems/add-two-numbers/
    public static class AddTwoNumbersSolution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode();
            ListNode node = new ListNode();

            head.next = node;

            while (l1 != null || l2 != null)
            {
                l1 = l1 ??= new ListNode();
                l2 = l2 ??= new ListNode();

                node.val += l1.val + l2.val;

                if (node.val > 9)
                {
                    node.val = node.val % 10;
                    node.next = new ListNode(1);
                }

                if (l1.next != null || l2.next != null)
                {
                    l1 = l1.next;
                    l2 = l2.next;
                    node = node.next ??= new ListNode();
                }
                else
                {
                    return head.next;
                }
            }

            return head.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
