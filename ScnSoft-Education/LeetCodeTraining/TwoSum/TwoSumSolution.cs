namespace LeetCodeTraining.TwoSum
{
    //https://leetcode.com/problems/two-sum/
    public static class TwoSumSolution
    {
        public static int[] TwoSumDictionary(int[] nums, int target)
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
                //2) both of the duplicated values are not components of target value because of discrepancy (only one answer)
                else if (nums[i] * 2 == target)
                {
                    return new int[2] { i, inputMap[nums[i]] };
                }

                continue;
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
