namespace LeetCodeTraining._3SumClosest
{
    //https://leetcode.com/problems/3sum-closest/
    public static class ThreeSumClosestSolution
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int maxDiff = 13000;
            int result = 0;
            int lp;
            int rp;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                lp = i + 1;
                rp = nums.Length - 1;

                while (lp < rp)
                {
                    int sum = nums[i] + nums[lp] + nums[rp];
                    int currentDiff = Math.Abs(sum - target);

                    if (sum == target)
                    {
                        return sum;
                    }

                    if (currentDiff <= maxDiff)
                    {
                        maxDiff = currentDiff;
                        result = sum;
                    }

                    if (sum > target)
                    {
                        while (rp > 2 && nums[rp] == nums[rp - 1])
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
