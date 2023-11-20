using LeetCodeTraining.AddTwoNumbers;
using System.Text;

namespace LeetCodeTraining.Tests
{
    public class AddTwoNumbersTests
    {
        [Theory]
        [InlineData(new int[] { 2, 4, 3 },
                    new int[] { 5, 6, 4 }, "708")]
        [InlineData(new int[] { 0 },
                    new int[] { 0 }, "0")]
        [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 },
                    new int[] { 9, 9, 9, 9 }, "89990001")]
        [InlineData(new int[] { 1 },
                    new int[] { 2 }, "3")]
        [InlineData(new int[] { 1, 2, 3 },
                    new int[] { 1, 2, 3 }, "246")]
        public void AddNumbersTests(int[] list1, int[] list2, string expectedResult)
        {
            //Arrange
            ListNode l1 = InitializeNode(list1);
            ListNode l2 = InitializeNode(list2);

            //Act
            string result = DisplayNode(AddTwoNumbersSolution.AddTwoNumbers(l1, l2));

            //Assert
            Assert.Equal(expectedResult, result);
        }

        private ListNode InitializeNode(int[] numbers)
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

        private string DisplayNode(ListNode node)
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
