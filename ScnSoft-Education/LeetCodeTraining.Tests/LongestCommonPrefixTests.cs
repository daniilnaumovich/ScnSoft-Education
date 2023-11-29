using LeetCodeTraining.LongestCommonPrefix;

namespace LeetCodeTraining.Tests
{
    public class LongestCommonPrefixTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void LongestCommonPrefixTest(string[] strs, string expectedResult)
        {
            //Act
            string result = LongestCommonPrefixSolution.LongestCommonPrefix(strs);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]
                {
                    new string[] { "flower", "flow", "flight" },
                    "fl"
                },
                new object[]
                {
                    new string[] { "dog", "racecar", "car" },
                    string.Empty
                },
                new object[]
                {
                    new string[] { "abc", "abc", "abc", "abc" },
                    "abc"
                },
                new object[]
                {
                    new string[] { "def" },
                    "def"
                },
                new object[]
                {
                    new string[] { "aabb", "abb" },
                    "a"
                }
            };
    }
}
