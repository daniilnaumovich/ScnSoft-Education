namespace LeetCodeTraining._3SumClosest
{
    //https://leetcode.com/problems/3sum-closest/
    public static class ThreeSumClosestSolution
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int diff = int.MaxValue;
            int result = 0;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int lp = i + 1;
                int rp = nums.Length - 1;

                while (lp < rp)
                {
                    int sum = nums[i] + nums[lp] + nums[rp];

                    if (sum == target)
                    {
                        return sum;
                    }

                    if (Math.Abs(sum - target) < diff)
                    {
                        diff = Math.Abs(sum - target);
                        result = sum;
                    }

                    if (sum > target)
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
