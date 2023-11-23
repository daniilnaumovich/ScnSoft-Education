using System.Text;

namespace LeetCodeTraining.StringToIntegerAtoi
{
    //https://leetcode.com/problems/string-to-integer-atoi/
    public static class StringToIntegerAtoiSolution
    {
        public static int MyAtoi(string s)
        {
            StringBuilder numberString = new StringBuilder();
            bool isNegative = false;
            int i = 0;

            if (s == string.Empty)
            {
                return 0;
            }

            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }

            if (i < s.Length && s[i] == '-')
            {
                isNegative = true;
                i++;
            }
            else if (i < s.Length && s[i] == '+')
            {
                i++;
            }

            if (i < s.Length && char.IsDigit(s[i]))
            {
                while (i < s.Length && char.IsDigit(s[i]))
                {
                    numberString.Append(s[i]);
                    i++;
                }
            }
            else
            {
                return 0;
            }

            string resultString = numberString.ToString().TrimStart('0');

            if (isNegative && int.MinValue.ToString().Length < resultString.Length)
            {
                return int.MinValue;
            }
            if (!isNegative && int.MaxValue.ToString().Length < resultString.Length)
            {
                return int.MaxValue;
            }

            if (long.TryParse(resultString, out long result))
            {
                if ((isNegative ? -result : result) > int.MaxValue)
                {
                    return int.MaxValue;
                }
                if ((isNegative ? -result : result) < int.MinValue)
                {
                    return int.MinValue;
                }

                return (int)(isNegative ? -result : result);
            }

            return 0;
        }
    }
}
