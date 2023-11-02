using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTraining.TwoSum
{
    //https://leetcode.com/problems/two-sum/
    public static class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }

            return new int[] { };
        }
    }
}
