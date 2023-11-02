using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTraining.TwoSumDictionary
{
    public static class TwoSumDictionarySolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> inputMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!inputMap.ContainsKey(nums[i]))
                {
                    inputMap.Add(nums[i], i);
                }
                //the cases when we have duplicate values in input array are:
                //1) the sum of duplicated values is the target value - return their indeces
                //2) both of the dulicated values are not components of target value because of discrepancy (only one answer)
                else if (nums[i] * 2 == target)
                {
                    return new int[2] { i, inputMap[nums[i]] };
                }
                else
                {
                    continue;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int correspondingValue = target - nums[i];

                if (inputMap.ContainsKey(correspondingValue) && inputMap[correspondingValue] != i)
                {
                    return new int[2] { i, inputMap[correspondingValue] };
                }
            }

            return new int[] { };
        }
    }
}
