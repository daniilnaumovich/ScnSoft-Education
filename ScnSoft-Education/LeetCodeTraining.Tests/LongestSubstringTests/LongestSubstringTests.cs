using LeetCodeTraining.LongestSubstring;

namespace LeetCodeTraining.Tests.LongestSubstringTests
{
    public class LongestSubstringTests
    {
        [Fact]
        public void LengthOfLongestSubstringSingleChar()
        {
            //Arrange
            string input = "a";
            int expectedResult = 1;

            //Act
            int result = LongestSubstringSolution.LengthOfLongestSubstring(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void LengthOfLongestSubstringDoubleChar()
        {
            //Arrange
            string input = "ab";
            int expectedResult = 2;

            //Act
            int result = LongestSubstringSolution.LengthOfLongestSubstring(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void LengthOfLongestSubstringMultipleCharsOne()
        {
            //Arrange
            string input = "abcabcbb";
            int expectedResult = 3;

            //Act
            int result = LongestSubstringSolution.LengthOfLongestSubstring(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void LengthOfLongestSubstringMultipleCharsTwo()
        {
            //Arrange
            string input = "bbbbb";
            int expectedResult = 1;

            //Act
            int result = LongestSubstringSolution.LengthOfLongestSubstring(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void LengthOfLongestSubstringMultipleCharsThree()
        {
            //Arrange
            string input = "pwwkew";
            int expectedResult = 3;

            //Act
            int result = LongestSubstringSolution.LengthOfLongestSubstring(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
