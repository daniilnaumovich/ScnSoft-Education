using LeetCodeTraining.StringToIntegerAtoi;

namespace LeetCodeTraining.Tests
{
    public class StringToIntegerAtoiTests
    {
        [Theory]
        [InlineData("42", 42)]
        [InlineData("   -42", -42)]
        [InlineData("4193 with words", 4193)]
        [InlineData("words and 222", 0)]
        [InlineData("onlywords", 0)]
        [InlineData("-+12", 0)]
        [InlineData("-2147483648", int.MinValue)]
        [InlineData("2147483647", int.MaxValue)]
        [InlineData("0", 0)]
        [InlineData("2000000000000000", int.MaxValue)]
        [InlineData("-1111111111111111111", int.MinValue)]
        public void MyAtoiTest(string s, int expectedResult)
        {
            //Act
            int result = StringToIntegerAtoiSolution.MyAtoi(s);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
