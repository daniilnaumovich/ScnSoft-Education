namespace LeetCodeTraining.SortColors
{
    //https://leetcode.com/problems/sort-colors/
    public static class SortColorsSolution
    {
        public static void SortColors(int[] nums)
        {
            int rptr = 0;
            int bptr = nums.Length;

            for (int i = 0; i < bptr; i++)
            {
                if (nums[i] == 0)
                {
                    Swap(rptr, i);
                    rptr++;
                    continue;
                }
                if (nums[i] == 2)
                {
                    Swap(i, bptr - 1);
                    bptr--;
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
