using System.Text;

namespace LeetCodeTraining.ReverseInteger
{
    //https://leetcode.com/problems/reverse-integer/
    public static class ReverseIntegerSolution
    {
        public static int Reverse(int x)
        {
            string positiveString = x.ToString();
            int sign = 1;
            StringBuilder builder = new StringBuilder();
            int result = 0;

            if (x < 0)
            {
                sign = -1;
                positiveString = (-1 * x).ToString();
            }

            for (int i = 0; i < positiveString.Length; i++)
            {
                builder.Append(positiveString[positiveString.Length - 1 - i]);
            }

            if (!int.TryParse(builder.ToString(), out result))
            {
                return 0;
            }

            return sign * result;
        }
    }
}
