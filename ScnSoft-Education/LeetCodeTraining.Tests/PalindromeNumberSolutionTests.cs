using LeetCodeTraining.PalindromeNumber;

namespace LeetCodeTraining.Tests
{
    public class PalindromeNumberSolutionTests
    {
        [Theory]
        [InlineData(-123, false)]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(121, true)]
        [InlineData(123454321, true)]
        [InlineData(121211, false)]
        [InlineData(1000, false)]
        [InlineData(1212121, true)]
        [InlineData(12122121, true)]
        public void IsPalindromeTest(int number, bool expectedResult)
        {
            //Act
            var result = PalindromeNumberSolution.IsPalindrome(number);

            //Assert
            Assert.Equal(result, expectedResult);         
        }
    }
}