namespace LeetCodeTraining.MergeKSortedLists
{
    //https://leetcode.com/problems/merge-k-sorted-lists/
    public static class MergeKSortedListsSolution
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
            {
                return null;
            }

            PriorityQueue<ListNode, int> queue = new PriorityQueue<ListNode, int>();
            ListNode currentNode;
            int value;

            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null)
                {
                    currentNode = lists[i];
                    queue.Enqueue(currentNode, currentNode.val);
                }
            }

            ListNode head = new ListNode();
            ListNode node = new ListNode();
            head = node;

            while (queue.TryDequeue(out currentNode, out value))
            {
                node.next = currentNode;

                node = node.next;
                if (currentNode.next == null)
                {
                    continue;
                }
                currentNode = currentNode.next;

                queue.Enqueue(currentNode, currentNode.val);
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
