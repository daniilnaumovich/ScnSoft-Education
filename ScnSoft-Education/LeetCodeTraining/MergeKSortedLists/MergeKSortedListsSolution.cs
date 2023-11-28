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
            ListNode node = new ListNode();
            ListNode head = node;

            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] != null)
                {
                    queue.Enqueue(lists[i], lists[i].val);
                }
            }

            while (queue.TryDequeue(out ListNode currentNode, out int value))
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
