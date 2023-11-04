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
        [InlineData(-130, -31)]
        [InlineData(2332, 2332)]
        public void ReverseTest(int x, int expectedResult)
        {
            //Act
            int result = ReverseIntegerSolution.Reverse(x);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
