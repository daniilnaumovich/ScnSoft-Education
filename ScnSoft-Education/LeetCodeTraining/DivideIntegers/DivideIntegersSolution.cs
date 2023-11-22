namespace LeetCodeTraining.DivideIntegers
{
    //https://leetcode.com/problems/divide-two-integers/
    public static class DivideIntegersSolution
    {
        public static int Divide(int dividend, int divisor)
        {
            if (dividend == 0)
            {
                return 0;
            }

            if (dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue;
            }

            int counter = 0;
            bool negativeResult = (dividend < 0 && divisor > 0) ||
                                  (dividend > 0 && divisor < 0);
            dividend = dividend > 0 ? dividend -= dividend + dividend : dividend;
            divisor = divisor < 0 ? divisor -= divisor + divisor : divisor;

            while (dividend < 0)
            {
                counter++;
                dividend += divisor;
            }

            if (dividend == 0)
            {
                return negativeResult ? counter -= counter + counter : counter;
            }

            return negativeResult ? counter -= counter + counter - 1 : counter - 1;
        }
    }
}
