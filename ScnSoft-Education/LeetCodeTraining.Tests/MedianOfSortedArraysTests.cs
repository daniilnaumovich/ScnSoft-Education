using LeetCodeTraining.MedianOfSortedArrays;

namespace LeetCodeTraining.Tests
{
    public class MedianOfSortedArraysTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 3, 4 }, 3)]
        [InlineData(new int[] { 0, 0 }, new int[2] { 0, 1000}, 0)]
        [InlineData(new int[] { 11, 12 }, new int[2] { 13, 14}, 12.5)]
        public void FindMedianSortedArraysTest(int[] nums1, int[] nums2, double expectedResult)
        {
            //Act
            double result = MedianOfSortedArraysSolution.FindMedianSortedArrays(nums1, nums2);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
