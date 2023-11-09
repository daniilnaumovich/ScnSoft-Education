using LeetCodeTraining.LongestCommonPrefix;

namespace LeetCodeTraining.Tests
{
    public class LongestCommonPrefixTests
    {
        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        [InlineData(new string[] { "abc", "abc", "abc", "abc" }, "abc")]
        [InlineData(new string[] { "def"}, "def")]
        [InlineData(new string[] { "aabb", "abb"}, "a")]
        public void LongestCommonPrefixTest(string[] strs, string expectedResult)
        {
            //Act
            string result = LongestCommonPrefixSolution.LongestCommonPrefix(strs);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
