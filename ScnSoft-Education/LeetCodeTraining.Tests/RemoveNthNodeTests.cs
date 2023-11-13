using LeetCodeTraining.RemoveNthNode;
using System.Text;

namespace LeetCodeTraining.Tests
{
    public class RemoveNthNodeTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, "1235")]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, "123467")]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5, "2345")]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, "1234")]
        [InlineData(new int[] { 1 }, 1, "")]
        [InlineData(new int[] { 1, 2 }, 1, "1")]
        public void RemoveNthNodeTest(int[] list, int number, string expectedResult)
        {
            //Arrange
            ListNode head = InitializeNode(list);

            //Act
            ListNode result = RemoveNthNodeSolution.RemoveNthFromEnd(head, number);
            string resultString = DisplayNode(result);

            //Assert
            Assert.Equal(expectedResult, resultString);

        }

        static ListNode InitializeNode(int[] numbers)
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

        static string DisplayNode(ListNode node)
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
