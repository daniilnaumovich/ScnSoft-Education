using LeetCodeTraining.RemoveElement;

namespace LeetCodeTraining.Tests
{
    public class RemoveElementTests
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        [InlineData(new int[] { 1 }, 1, 0)]
        [InlineData(new int[] { 5 }, 1, 1)]
        [InlineData(new int[] { 1, 1, 1, 1, 2 }, 1, 1)]
        [InlineData(new int[] { 2, 2, 2 }, 2, 0)]
        public void RemoveElementTest(int[] nums, int val, int expectedResult)
        {
            //Act
            int result = RemoveElementSolution.RemoveElement(nums, val);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
