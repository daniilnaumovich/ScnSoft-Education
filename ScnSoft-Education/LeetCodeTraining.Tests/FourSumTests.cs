using LeetCodeTraining.FourSum;

namespace LeetCodeTraining.Tests
{
    public class FourSumTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void FourSumTest(int[] nums, int target, IList<IList<int>> expectedResult)
        {
            //Act
            IList<IList<int>> result = FourSumSolution.FourSum(nums, target);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]
                {
                    //nums
                    new int[] { 1, 0, -1, 0, -2, 2 }, 
                    //target
                    0,      
                    //expectedResult
                    new List<IList<int>>()                  
                    {
                        new List<int>() { -2, -1, 1, 2 },
                        new List<int>() { -2, 0, 0, 2 },
                        new List<int>() { -1, 0, 0, 1 }
                    }
                },
                new object[]
                {
                    new int[] { 2, 2, 2, 2, 2 },
                    8,
                    new List<IList<int>>() 
                    {
                        new List<int>() { 2, 2, 2, 2 }
                    }
                },
                new object[]
                {
                    new int[] { -1, 0, 3, -3, 2, 1, -2 },
                    2,
                    new List<IList<int>>()
                    {
                        new List<int>() { -3, 0, 2, 3 },
                        new List<int>() { -2, -1, 2, 3 },
                        new List<int>() { -2, 0, 1, 3 },
                        new List<int>() { -1, 0, 1, 2 }
                    }
                },
                new object[]
                {
                    new int[] { 2, 2, 3, 4 },
                    -1,
                    new List<IList<int>>() { }
                },
                new object[]
                {
                    new int[] { 2 },
                    2,
                    new List<IList<int>>() { }
                }
            };
    }
}
