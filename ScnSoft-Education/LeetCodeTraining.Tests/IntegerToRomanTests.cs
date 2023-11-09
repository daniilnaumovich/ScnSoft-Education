using LeetCodeTraining.IntegerToRoman;

namespace LeetCodeTraining.Tests
{
    public class IntegerToRomanTests
    {
        [Theory]
        [InlineData(3, "III")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        [InlineData(3999, "MMMCMXCIX")]
        [InlineData(1999, "MCMXCIX")]
        [InlineData(777, "DCCLXXVII")]
        [InlineData(888, "DCCCLXXXVIII")]
        [InlineData(1475, "MCDLXXV")]
        public void IntToRomanTests(int number, string expectedResult)
        {
            //Act
            string result = IntegerToRomanSolution.IntToRoman(number);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
