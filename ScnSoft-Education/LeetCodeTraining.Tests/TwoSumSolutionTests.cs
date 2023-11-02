using LeetCodeTraining.TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTraining.Tests
{
    public class TwoSumSolutionTests
    {
        [Fact]
        public void TwoSum_ArrayWith2Nums()
        {
            //Arrange
            var nums = new int[] { 3, 3 };
            int target = 6;
            var expectedResult = new int[] { 0, 1 };

            //Act
            var result = TwoSumSolution.TwoSum(nums, target);

            //Assert
            Assert.Equal(expectedResult.Length, result.Length);
            Array.Sort(result);
            for(int i = 0; i< expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void TwoSum_ArrayWith3Nums()
        {
            //Arrange
            var nums = new int[] { 3, 2, 4 };
            int target = 6;
            var expectedResult = new int[] { 1, 2 };

            //Act
            var result = TwoSumSolution.TwoSum(nums, target);

            //Assert
            Assert.Equal(expectedResult.Length, result.Length);
            Array.Sort(result);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void TwoSum_ArrayWith4Nums()
        {
            //Arrange
            var nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            var expectedResult = new int[] { 0, 1 };

            //Act
            var result = TwoSumSolution.TwoSum(nums, target);

            //Assert
            Assert.Equal(expectedResult.Length, result.Length);
            Array.Sort(result);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}
