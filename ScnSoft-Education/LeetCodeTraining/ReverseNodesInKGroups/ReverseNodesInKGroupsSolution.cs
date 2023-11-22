namespace LeetCodeTraining.ReverseNodesInKGroups
{
    //https://leetcode.com/problems/reverse-nodes-in-k-group/
    public static class ReverseNodesInKGroupsSolution
    {
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k == 1)
            {
                return head;
            }

            ListNode kth = head;
            for (int i = 0; i < k; i++)
            {
                if (kth == null)
                {
                    return head;
                }

                kth = kth.next;
            }

            ListNode prev;
            ListNode post = head.next;

            prev = head;
            head = post;
            prev.next = ReverseKGroup(kth, k);
            post = head.next;
            head.next = prev;

            for (int i = 0; i < k - 2; i++)
            {
                prev = head;
                head = post;
                post = head.next;
                head.next = prev;
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
                    if ((node.next == null && item.next != null) ||
                        (node.next != null && item.next == null))
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
