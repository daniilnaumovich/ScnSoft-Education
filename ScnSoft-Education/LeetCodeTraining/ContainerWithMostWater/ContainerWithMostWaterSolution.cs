namespace LeetCodeTraining.ContainerWithMostWater
{
    //https://leetcode.com/problems/container-with-most-water/
    public static class ContainerWithMostWaterSolution
    {
        public static int MaxArea(int[] height)
        {
            int leftIndex = 0;
            int rightIndex = height.Length - 1;
            int maxVolume = GetCurrentVolume();

            if (height.Length == 2)
            {
                return maxVolume;
            }

            while (true)
            {
                while (height[leftIndex] <= height[rightIndex])
                {
                    if (rightIndex <= leftIndex++)
                    {
                        return maxVolume;
                    }

                    SetMaxVolume();
                }

                while (height[rightIndex] <= height[leftIndex])
                {
                    if (rightIndex-- <= leftIndex)
                    {
                        return maxVolume;
                    }

                    SetMaxVolume();
                }
            }

            int GetCurrentVolume()
            {
                return Math.Min(height[leftIndex], height[rightIndex]) * (rightIndex - leftIndex);
            }

            void SetMaxVolume()
            {
                int currentVolume = GetCurrentVolume();

                if (currentVolume > maxVolume)
                {
                    maxVolume = currentVolume;
                }
            }
        }
    }
}
