using LeetCodeTraining.LongestSubstring;

namespace LeetCodeTraining.Tests
{
    public class LongestSubstringTests
    {
        [Theory]
        [InlineData("a", 1)]
        [InlineData("ab", 2)]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void LengthOfLongestSubstringMultipleChars(string input, int expectedResult)
        {
            //Act
            int result = LongestSubstringSolution.LengthOfLongestSubstring(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
