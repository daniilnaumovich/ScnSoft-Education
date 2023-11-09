namespace LeetCodeTraining.ContainerWithMostWater
{
    //https://leetcode.com/problems/container-with-most-water/
    public static class ContainerWithMostWaterSolution
    {
        public static int MaxArea(int[] height)
        {
            int leftIndex = 0;
            int rightIndex = height.Length - 1;
            int currentVolume;

            int maxVolume = Math.Min(height[0], height[height.Length - 1]) * (height.Length - 1);

            if (height.Length == 2)
            {
                return maxVolume;
            }

            while (true)
            {
                while (height[leftIndex] <= height[rightIndex])
                {
                    if (leftIndex >= rightIndex)
                    {
                        break;
                    }

                    leftIndex++;

                    currentVolume = Math.Min(height[leftIndex], height[rightIndex]) * (rightIndex - leftIndex);
                    if (currentVolume > maxVolume)
                    {
                        maxVolume = currentVolume;
                    }
                }

                while (height[rightIndex] <= height[leftIndex])
                {
                    if (rightIndex <= leftIndex)
                    {
                        break;
                    }

                    rightIndex--;

                    currentVolume = Math.Min(height[leftIndex], height[rightIndex]) * (rightIndex - leftIndex);
                    if (currentVolume > maxVolume)
                    {
                        maxVolume = currentVolume;
                    }
                }

                if (leftIndex >= rightIndex)
                {
                    break;
                }
            }

            return maxVolume;
        }
    }
}
