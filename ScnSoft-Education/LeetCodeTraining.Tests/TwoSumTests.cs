using LeetCodeTraining.TwoSum;

namespace LeetCodeTraining.Tests
{
    public class TwoSumSolutionTests
    {
        [Theory]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        public void TwoSum_ArrayWithMultipleNums(int[] nums, int target, int[] expectedResult)
        {
            //Act
            var result = TwoSumSolution.TwoSum(nums, target);
            Array.Sort(result);

            //Assert
            Assert.Equal(expectedResult.Length, result.Length);       
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Theory]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        public void TwoSum_ArrayWithMultipleNumsDictionary(int[] nums, int target, int[] expectedResult)
        {
            //Act
            var result = TwoSumSolution.TwoSumDictionary(nums, target);
            Array.Sort(result);

            //Assert
            Assert.Equal(expectedResult.Length, result.Length);         
            for(int i = 0; i< expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}