using LeetCodeTraining.RemoveDuplicates;

namespace LeetCodeTraining.Tests
{
    public class RemoveDuplicatesTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, 1)]
        public void RemoveDuplicatesTest(int[] nums, int expectedResult)
        {
            //Act
            int result = RemoveDuplicatesSolution.RemoveDuplicates(nums);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
