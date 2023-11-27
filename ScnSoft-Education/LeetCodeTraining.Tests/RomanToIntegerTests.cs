using LeetCodeTraining.RomanToInteger;

namespace LeetCodeTraining.Tests
{
    public class RomanToIntegerTests
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("MMMCMXCIX", 3999)]
        [InlineData("IV", 4)]
        [InlineData("MLXXVI", 1076)]
        [InlineData("MCCXXXIV", 1234)]
        public void RomanToIntTests(string input, int expectedResult)
        {
            //Act
            int result = RomanToIntegerSolution.RomanToInt(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
