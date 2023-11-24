using LeetCodeTraining.LongestPalindrome;

namespace LeetCodeTraining.Tests
{
    public class LongestPalindromeTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void LongestPalindromeTest(string input, string[] expectedResults)
        {
            //Act
            string result = LongestPalindromeSolution.LongestPalindrome(input);

            //Assert
            Assert.Contains(expectedResults, x => x == result);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void LongestPalindromeAlternativeTest(string input, string[] expectedResults)
        {
            //Act
            string result = LongestPalindromeSolution.LongestPalindromeAlternative(input);

            //Assert
            Assert.Contains(expectedResults, x => x == result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { "babad", new string[] { "bab", "aba" } },
            new object[] { "cbbd", new string[] { "bb" } },
            new object[] { "ccc", new string[] { "ccc" } },
            new object[] { "a", new string[] { "a" } },
            new object[] { "dd", new string[] { "dd" } },
            new object[] { "abab", new string[] { "aba", "bab" } },
            new object[] { "cccc", new string[] { "cccc" } },
            new object[] { "babba", new string[] { "abba" } },
            new object[] { "fabccbad", new string[] { "abccba" } },
            new object[] { "bcbabdb", new string[] { "bcb", "bab", "bdb" }}
        };
    }
}
