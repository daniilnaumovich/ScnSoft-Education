namespace LeetCodeTraining.FourSum
{
    //https://leetcode.com/problems/4sum/
    public static class FourSumSolution
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            int lp;
            int rp;

            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }

                    lp = j + 1;
                    rp = nums.Length - 1;

                    while (lp < rp)
                    {
                        long sum = (long)nums[i] + (long)nums[j] + (long)nums[lp] + (long)nums[rp];

                        if (sum == target)
                        {
                            result.Add(new List<int>() { nums[i], nums[j], nums[lp], nums[rp] });
                        }
                        else if (sum > target)
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
            }

            return result;
        }
    }
}
