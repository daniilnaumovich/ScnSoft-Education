using LeetCodeTraining.LongestPalindrome;

namespace LeetCodeTraining.Tests
{
    public class LongestPalindromeTests
    {
        [Theory]
        [InlineData("babad", new string[] { "bab", "aba" })]
        [InlineData("cbbd", new string[] { "bb" })]
        [InlineData("ccc", new string[] { "ccc" })]
        [InlineData("a", new string[] { "a" })]
        [InlineData("dd", new string[] { "dd" })]
        [InlineData("abab", new string[] { "aba", "bab" })]
        [InlineData("cccc", new string[] { "cccc" })]
        [InlineData("bcbabdb", new string[] { "bcb", "bab", "bdb" })]
        public void LongestPalindromeTest(string input, string[] expectedResults)
        {
            //Act
            string result = LongestPalindromeSolution.LongestPalindrome(input);

            //Assert
            Assert.Contains(expectedResults, x => x == result);
        }
    }
}
