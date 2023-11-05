using LeetCodeTraining.ReverseInteger;

namespace LeetCodeTraining.Tests
{
    public class ReverseIntegerTests
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        [InlineData(-1, -1)]
        [InlineData(-120, -21)]
        [InlineData(121, 121)]
        [InlineData(-1234321, -1234321)]
        public void ReverseTest(int x, int expectedResult)
        {
            //Act
            int result = ReverseIntegerSolution.Reverse(x);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
