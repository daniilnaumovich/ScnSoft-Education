namespace LeetCodeTraining.RemoveNthNode
{
    //https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    public static class RemoveNthNodeSolution
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null)
            {
                return null;
            }

            ListNode first = new ListNode();
            first.next = head;
            ListNode tail = first;
            ListNode start = tail.next.next;
            ListNode end = start;

            for (int i = 0; i < n - 2; i++)
            {
                end = end.next;
            }

            while (true)
            {
                if (end.next != null)
                {
                    end = end.next;
                    start = start.next;
                    tail = tail.next;
                }
                else
                {
                    if (n == 1)
                    {
                        tail.next.next = null;
                    }
                    else
                    {
                        tail.next = start;
                    }

                    break;
                }
            }

            return first.next;
        }

        public static ListNode RemoveNthFromEndRec(ListNode head, int n)
        {
            ListNode first = new ListNode();
            first.next = head;
            int distance = 0;

            CalculateDistance(first);

            return first.next;

            void CalculateDistance(ListNode head)
            {
                if (head.next == null)
                {
                    distance = 1;
                    return;
                }

                CalculateDistance(head.next);

                if (distance == n)
                {
                    head.next = head.next.next;
                }

                if (distance > 0)
                {
                    distance++;
                }
            }
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
