namespace LeetCodeTraining.RemoveDuplicates
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    public static class RemoveDuplicatesSolution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            HashSet<int> uniqueNums = new HashSet<int>(nums);

            int index = 0;
            foreach (int num in uniqueNums)
            {
                nums[index] = num;
                index++;
            }

            return uniqueNums.Count();
        }
    }
}
