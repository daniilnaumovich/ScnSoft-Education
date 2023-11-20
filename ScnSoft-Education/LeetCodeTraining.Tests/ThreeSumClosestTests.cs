using LeetCodeTraining._3SumClosest;

namespace LeetCodeTraining.Tests
{
    public class ThreeSumClosestTests
    {
        [Theory]
        [InlineData(new int[] { -1, 2, 1, -4 }, 1, 2)]
        [InlineData(new int[] { 0, 0, 0 }, 1, 0)]
        [InlineData(new int[] { 1, 2, 4, 10 }, int.MaxValue, 16)]
        [InlineData(new int[] { -6, -20, 3, 6, -7 }, int.MinValue, -33)]
        [InlineData(new int[] { 1, 1, 1 }, 1, 3)]
        [InlineData(new int[] { -4, -2, 0, 2, 4, -3, -1, 1, 3 }, -10, -9)]
        [InlineData(new int[] { -4, -2, 0, 2, 4, -3, -1, 1, 3 }, 10, 9)]
        [InlineData(new int[] { -4, -2, 0, 2, 4, -3, -1, 1, 3 }, -5, -5)]
        [InlineData(new int[] { -4, -2, 0, 2, 4, -3, -1, 1, 3 }, 4, 4)]
        public void ThreeSumClosestTest(int[] nums, int target, int expectedResult)
        {
            //Act
            int result = ThreeSumClosestSolution.ThreeSumClosest(nums, target);

            //Assert
            Assert.Equal(result, expectedResult);
        }
    }
}
