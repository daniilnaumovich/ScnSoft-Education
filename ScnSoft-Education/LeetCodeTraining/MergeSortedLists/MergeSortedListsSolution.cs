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
                    start.next = list2;
                    start = start.next;
                    list2 = list2.next;
                }
                else
                {
                    start.next = list1;
                    start = start.next;
                    list1 = list1.next;
                }
            }

            while (list1 != null)
            {
                start.next = list1;
                start = start.next;
                list1 = list1.next;
            }
            while (list2 != null)
            {
                start.next = list2;
                start = start.next;
                list2 = list2.next;
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
