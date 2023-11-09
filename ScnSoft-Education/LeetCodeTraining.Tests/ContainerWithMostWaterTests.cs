using LeetCodeTraining.ContainerWithMostWater;

namespace LeetCodeTraining.Tests
{
    public class ContainerWithMostWaterTests
    {
        [Theory]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 2, 2 }, 2)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { 0, 1 }, 0)]
        [InlineData(new int[] { 2, 3, 4, 5, 18, 17, 6 }, 17)]
        [InlineData(new int[] { 1, 2, 2, 0, 0, 0, 1 }, 6)]
        [InlineData(new int[] { 1, 7, 7, 0, 0, 0, 1 }, 7)]
        [InlineData(new int[] { 2, 3, 4, 3, 5, 25, 24, 6 }, 24)]
        public void MaxAreaTests(int[] heights, int expectedResult)
        {
            //Act
            int result = ContainerWithMostWaterSolution.MaxArea(heights);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
