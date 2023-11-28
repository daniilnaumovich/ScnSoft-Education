namespace LeetCodeTraining.MergeSortedLists
{
    //https://leetcode.com/problems/merge-two-sorted-lists/
    public static class MergeSortedListsSolution
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode start = new ListNode();
            ListNode head = start;

            while (list1 != null && list2 != null)
            {
                if (list1.val > list2.val)
                {
                    list2 = AddNode(list2);
                }
                else
                {
                    list1 = AddNode(list1);
                }
            }

            while (list1 != null)
            {
                list1 = AddNode(list1);
            }
            while (list2 != null)
            {
                list2 = AddNode(list2);
            }

            return head.next;

            ListNode AddNode(ListNode node)
            {
                start.next = node;
                start = start.next;
                return node.next;
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
