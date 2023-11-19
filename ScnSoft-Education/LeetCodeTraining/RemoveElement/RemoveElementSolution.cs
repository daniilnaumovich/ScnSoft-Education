namespace LeetCodeTraining.RemoveElement
{
    //https://leetcode.com/problems/remove-element/
    public static class RemoveElementSolution
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int currentIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[currentIndex] = nums[i];
                    currentIndex++;
                }
            }

            return currentIndex;
        }
    }
}
