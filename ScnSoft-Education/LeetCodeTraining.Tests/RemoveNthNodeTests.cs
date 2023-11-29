using LeetCodeTraining.RemoveNthNode;
using System.Text;

namespace LeetCodeTraining.Tests
{
    public class RemoveNthNodeTests
    {
        [Theory]
        [MemberData(nameof(Data))]
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

        [Theory]
        [MemberData(nameof(Data))]
        public void RemoveNthNodeRecTest(int[] list, int number, string expectedResult)
        {
            //Arrange
            ListNode head = InitializeNode(list);

            //Act
            ListNode result = RemoveNthNodeSolution.RemoveNthFromEndRec(head, number);
            string resultString = DisplayNode(result);

            //Assert
            Assert.Equal(expectedResult, resultString);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]
                {
                    new int[] { 1, 2, 3, 4, 5 },
                    2,
                    "1235"
                },
                new object[]
                {
                    new int[] { 1, 2, 3, 4, 5, 6, 7 },
                    3,
                    "123467"
                },
                new object[]
                {
                    new int[] { 1, 2, 3, 4, 5 },
                    5,
                    "2345"
                },
                new object[]
                {
                    new int[] { 1, 2, 3, 4, 5 },
                    1,
                    "1234"
                },
                new object[]
                {
                    new int[] { 1 },
                    1,
                    string.Empty
                },
                new object[]
                {
                    new int[] { 1, 2 },
                    1,
                    "1"
                }
            };

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
                    continue;
                }

                break;
            }

            return sb.ToString();
        }
    }
}
