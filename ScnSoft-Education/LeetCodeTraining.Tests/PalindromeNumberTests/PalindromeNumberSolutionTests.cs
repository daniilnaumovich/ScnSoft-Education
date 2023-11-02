using LeetCodeTraining.PalindromeNumber;

namespace LeetCodeTraining.Tests.PalindromeNumber
{
    public class PalindromeNumberSolutionTests
    {
        [Fact]
        public void IsPalindrome_Negative()
        {
            //Arrange
            var number = -123;
            bool expectedResult = false;

            //Act
            var result = PalindromeNumberSolution.IsPalindrome(number);

            //Assert
            Assert.Equal(result, expectedResult);         
        }

        [Fact]
        public void IsPalindrome_Zero()
        {
            //Arrange
            var number = 0;
            bool expectedResult = false;

            //Act
            var result = PalindromeNumberSolution.IsPalindrome(number);

            //Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void IsPalindrome_EndsWithZero()
        {
            //Arrange
            var number = 20;
            bool expectedResult = false;

            //Act
            var result = PalindromeNumberSolution.IsPalindrome(number);

            //Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void IsPalindrome_First()
        {
            //Arrange
            var number = 12321;
            bool expectedResult = true;

            //Act
            var result = PalindromeNumberSolution.IsPalindrome(number);

            //Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void IsPalindrome_Second()
        {
            //Arrange
            var number = 11221;
            bool expectedResult = false;

            //Act
            var result = PalindromeNumberSolution.IsPalindrome(number);

            //Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void IsPalindrome_Third()
        {
            //Arrange
            var number = 1232321;
            bool expectedResult = true;

            //Act
            var result = PalindromeNumberSolution.IsPalindrome(number);

            //Assert
            Assert.Equal(result, expectedResult);
        }


    }
}