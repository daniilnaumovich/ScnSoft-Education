using LeetCodeTraining.ThreeSum;

namespace LeetCodeTraining.Tests
{
    public class ThreeSumTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void ThreeSumTest(int[] nums, IList<IList<int>> expectedResult)
        {
            //Act
            IList<IList<int>> result = ThreeSumSolution.ThreeSum(nums);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]
                {
                    new int[] { -1, 0, 1, 2, -1, -4 },
                    new List<IList<int>>()
                    {
                        new List<int>() { -1, -1, 2 },
                        new List<int>() { -1, 0, 1 }
                    }
                },
                new object[]
                {
                    new int[] { 0, 1, 1 },
                    new List<IList<int>>() { }
                },
                new object[]
                {
                    new int[] { 0, 0, 0 },
                    new List<IList<int>>()
                    {
                        new List<int>() { 0, 0, 0 }
                    }
                },
                new object[]
                {
                    new int[] { 0, 1, 2, -2, -1, 3, 0, 0 },
                    new List<IList<int>>()
                    {
                        new List<int>() { -2, -1, 3 },
                        new List<int>() { -2, 0, 2 },
                        new List<int>() { -1, 0, 1 },
                        new List<int>() { 0, 0, 0 }
                    }
                }
            };
    }
}
