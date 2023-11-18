namespace LeetCodeTraining.MedianOfSortedArrays
{
    //https://leetcode.com/problems/median-of-two-sorted-arrays/
    public static class MedianOfSortedArraysSolution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] shorter;
            int[] longer;

            if (nums1.Length < nums2.Length)
            {
                shorter = nums1;
                longer = nums2;
            }
            else
            {
                shorter = nums2;
                longer = nums1;
            }

            if (shorter.Length == 0)
            {
                return longer.Length % 2 == 0
                    ? (double)(longer[longer.Length / 2 - 1] + longer[longer.Length / 2]) / 2
                    : longer[longer.Length / 2];
            }

            if (shorter.Length == 1 && longer.Length == 1)
            {
                return (double)(shorter[0] + longer[0]) / 2;
            }

            int resultIndex = (nums1.Length + nums2.Length + 1) / 2;

            int left = 0;
            int right = shorter.Length;

            int sr = 0,
                sl = 0,
                lr = 0,
                ll = 0;

            while (left <= right)
            {
                int shorterPtr = (right + left) / 2;

                int longerPtr = resultIndex - shorterPtr;

                sr = shorterPtr < shorter.Length ? shorter[shorterPtr] : int.MaxValue;
                sl = shorterPtr - 1 >= 0 ? shorter[shorterPtr - 1] : int.MinValue;
                lr = longerPtr < longer.Length ? longer[longerPtr] : int.MaxValue;
                ll = longerPtr - 1 >= 0 ? longer[longerPtr - 1] : int.MinValue;

                if (sr >= ll && lr >= sl)
                {
                    break;
                }
                else if (sl > lr)
                {
                    right = shorterPtr - 1;
                }
                else
                {
                    left = shorterPtr + 1;
                }
            }

            if ((shorter.Length + longer.Length) % 2 == 0)
            {
                return (double)(Math.Max(sl, ll) + Math.Min(sr, lr)) / 2;
            }
            else
            {
                return Math.Max(sl, ll);
            }
        }
    }
}
