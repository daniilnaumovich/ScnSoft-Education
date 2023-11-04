using LeetCodeTraining.ZigzagConversion;

namespace LeetCodeTraining.Tests
{
    public class ZigzagConversionTests
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("PAYPALISHIRING", 1, "PAYPALISHIRING")]
        [InlineData("PAYPALISHIRING", 2, "PYAIHRNAPLSIIG")]
        [InlineData("A", 1, "A")]
        [InlineData("A", 2, "A")]
        [InlineData("A", 3, "A")]
        [InlineData("ABC", 1, "ABC")]
        [InlineData("ABC", 2, "ACB")]
        public void FindMedianSortedArraysTest(string input, int numRows, string expectedResult)
        {
            //Act
            string result = ZigzagConversionSolution.Convert(input, numRows);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
