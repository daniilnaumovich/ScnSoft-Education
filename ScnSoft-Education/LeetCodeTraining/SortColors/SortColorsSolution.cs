namespace LeetCodeTraining.SortColors
{
    //https://leetcode.com/problems/sort-colors/
    public static class SortColorsSolution
    {
        public static void SortColors(int[] nums)
        {
            int lp = 0;
            int rp = nums.Length;

            for (int i = 0; i < rp; i++)
            {
                if (nums[i] == 0)
                {
                    Swap(lp, i);
                    lp++;
                    continue;
                }

                if (nums[i] == 2)
                {
                    Swap(i, rp - 1);
                    rp--;

                    if (nums[i] != 1)
                    {
                        i--;
                    }
                }
            }

            void Swap(int firstIndex, int secondIndex)
            {
                int number = nums[firstIndex];
                nums[firstIndex] = nums[secondIndex];
                nums[secondIndex] = number;
            }
        }
    }
}
