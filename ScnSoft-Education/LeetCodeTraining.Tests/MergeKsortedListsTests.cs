﻿using LeetCodeTraining.MergeKSortedLists;
using System.Text;

namespace LeetCodeTraining.Tests
{
    public class MergeKsortedListsTests
    {
        [Theory]
        [InlineData("")]
        [InlineData("", new int[] { })]
        [InlineData("11234456", new int[] { 1, 4, 5 }, new int[] { 1, 3, 4 }, new int[] { 2, 6 })]
        [InlineData("123456", new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 })]
        [InlineData("12", new int[] { 1 }, new int[] { 2 }, new int[] { })]
        public void MergeKListsTests(string expectedResult, params int[][] nums)
        {
            //Arrange
            ListNode[] lists = new ListNode[nums.Length];
            for (int i = 0;  i < nums.Length; i++)
            {
                lists[i] = InitializeNode(nums[i]);
            }

            //Act
            ListNode result = MergeKSortedListsSolution.MergeKLists(lists);
            string resultString = DisplayNode(result);

            //Assert
            Assert.Equal(resultString, expectedResult);
        }

        ListNode InitializeNode(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return null;
            }

            ListNode h = new ListNode(numbers[0]);

            if (numbers.Length > 1)
            {
                ListNode n = new ListNode(numbers[1]);
                h.next = n;
                for (int i = 2; i < numbers.Length; i++)
                {
                    n.next = new ListNode(numbers[i]);
                    n = n.next;
                }
            }

            return h;
        }

        string DisplayNode(ListNode node)
        {
            StringBuilder sb = new StringBuilder();

            while (node != null)
            {
                sb.Append(node.val);

                if (node.next != null)
                {
                    node = node.next;
                }
                else
                {
                    break;
                }
            }

            return sb.ToString();
        }
    }
}
