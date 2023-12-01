using System;
using System.Reflection;

namespace LeetCodeTraining.NextPermutation
{
    //https://leetcode.com/problems/next-permutation/
    public static class NextPermutationSolution
    {
        public static void NextPermutation(int[] nums)
        {
            int revertIndex = -1;
            int swapIndex = -1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] > nums[i])
                {
                    revertIndex = i;
                }

                if (revertIndex != -1 && nums[i + 1] > nums[revertIndex])
                {
                    swapIndex = i + 1;
                }
            }

            if (revertIndex != -1 && swapIndex != -1)
            {
                Swap(ref nums[revertIndex], ref nums[swapIndex]);
            }

            for (int i = 0; i < (nums.Length - revertIndex - 1) / 2; i++)
            {
                Swap(ref nums[revertIndex + i + 1], ref nums[nums.Length - i - 1]);
            }

            void Swap(ref int first, ref int second)
            {
                int swap = first;
                first = second;
                second = swap;
            }
        }
    }
}
