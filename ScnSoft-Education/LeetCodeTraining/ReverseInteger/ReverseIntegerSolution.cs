using System.Text;

namespace LeetCodeTraining.ReverseInteger
{
    //https://leetcode.com/problems/reverse-integer/
    public static class ReverseIntegerSolution
    {
        public static int Reverse(int x)
        {
            string positiveString = x.ToString();
            bool isPositive = true;
            StringBuilder builder = new StringBuilder();

            if (x < 0)
            {
                isPositive = false;
                positiveString = positiveString.Substring(1);
            }

            for (int i = 0; i < positiveString.Length; i++)
            {
                builder.Append(positiveString[positiveString.Length - 1 - i]);
            }

            if (!int.TryParse(builder.ToString(), out int result))
            {
                return 0;
            }

            return isPositive ? result : -result;
        }
    }
}
