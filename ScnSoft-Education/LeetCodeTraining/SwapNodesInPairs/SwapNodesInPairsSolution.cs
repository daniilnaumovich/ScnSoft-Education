namespace LeetCodeTraining.SwapNodesInPairs
{
    //https://leetcode.com/problems/swap-nodes-in-pairs/
    public static class SwapNodesInPairsSolution
    {
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode swap = head;
            ListNode nextHead = head.next.next;
            head = head.next;
            swap.next = null;
            head.next = swap;

            if (nextHead != null)
            {
                head.next.next = SwapPairs(nextHead);
            }

            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(int[] numbers)
        {
            this.val = numbers[0];

            if (numbers.Length > 1)
            {
                ListNode n = new ListNode(numbers[1]);
                this.next = n;

                for (int i = 2; i < numbers.Length; i++)
                {
                    n.next = new ListNode(numbers[i]);
                    n = n.next;
                }
            }
        }

        public override bool Equals(object? obj)
        {
            var item = obj as ListNode;

            if (item == null)
            {
                return false;
            }

            ListNode node = this;

            while (node != null && item != null)
            {
                if (node.val == item.val)
                {
                    if ((node.next == null) != (item.next == null))
                    {
                        return false;
                    }

                    node = node.next;
                    item = item.next;
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
