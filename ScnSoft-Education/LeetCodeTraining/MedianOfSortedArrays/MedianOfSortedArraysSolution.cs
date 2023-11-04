namespace LeetCodeTraining.MedianOfSortedArrays
{
    //https://leetcode.com/problems/median-of-two-sorted-arrays/
    public static class MedianOfSortedArraysSolution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] resultingArray = new int[nums1.Length + nums2.Length];

            for (int i = 0; i < nums1.Length; i++)
            {
                resultingArray[i] = nums1[i];
            }

            for (int i = nums1.Length; i < resultingArray.Length; i++)
            {
                resultingArray[i] = nums2[i - nums1.Length];
            }

            Array.Sort(resultingArray);

            if (resultingArray.Length % 2 == 1)
            {
                return (double)resultingArray[resultingArray.Length / 2];
            }
            else
            {
                return ((double)resultingArray[resultingArray.Length / 2] + (double)resultingArray[resultingArray.Length / 2 - 1]) / 2;
            }
        }
    }
}
