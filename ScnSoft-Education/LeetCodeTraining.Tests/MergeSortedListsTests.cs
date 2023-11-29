using LeetCodeTraining.MergeSortedLists;
using System.Text;

namespace LeetCodeTraining.Tests
{
    public class MergeSortedListsTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void MergeTwoListsTests(int[] list1, int[] list2, string expectedResult)
        {
            //Arrange
            ListNode l1 = InitializeNode(list1);
            ListNode l2 = InitializeNode(list2);

            //Act
            ListNode result = MergeSortedListsSolution.MergeTwoLists(l1, l2);
            string resultString = DisplayNode(result);

            //Assert
            Assert.Equal(expectedResult, resultString);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]
                {
                    new int[] { 1, 2, 4 },
                    new int[] { 1, 3, 4 },
                    "112344"
                },
                new object[]
                {
                    new int[] { },
                    new int[] { },
                    string.Empty
                },
                new object[]
                {
                    new int[] { },
                    new int[] { 0 },
                    "0"
                },
                new object[]
                {
                    new int[] { 1, 1 },
                    new int[] { 1, 1 },
                    "1111"
                },
                new object[]
                {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 },
                    "123456"
                },
                new object[]
                {
                    new int[] { 2, 3, 4 },
                    new int[] { 1, 5 },
                    "12345"
                }
            };

        public ListNode InitializeNode(int[] numbers)
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

        public string DisplayNode(ListNode node)
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
