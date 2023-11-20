namespace LeetCodeTraining.ThreeSum
{
    //https://leetcode.com/problems/3sum/
    public static class ThreeSumSolution
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int lp = i + 1;
                int rp = nums.Length - 1;
                int target = -1 * nums[i];

                while (lp < rp)
                {
                    int sum = nums[lp] + nums[rp];

                    if (sum == target)
                    {
                        result.Add(new List<int>() { nums[i], nums[lp], nums[rp] });
                    }
                    else if (sum > target)
                    {
                        while (rp >= 1 && nums[rp] == nums[rp - 1])
                        {
                            rp--;
                        }
                        rp--;
                        continue;
                    }
                    while (lp < nums.Length - 1 && nums[lp] == nums[lp + 1])
                    {
                        lp++;
                    }
                    lp++;
                }
            }

            return result;
        }
    }
}
