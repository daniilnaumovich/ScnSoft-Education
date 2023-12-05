namespace LeetCodeTraining.RemoveDuplicates
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    public static class RemoveDuplicatesSolution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int index = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[index++] = nums[i];
                }
            }

            return index;
        }
    }
}
