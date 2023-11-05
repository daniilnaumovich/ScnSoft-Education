namespace LeetCodeTraining.StringToIntegerAtoi
{
    //https://leetcode.com/problems/string-to-integer-atoi/
    public static class StringToIntegerAtoiSolution
    {
        public static int MyAtoi(string s)
        {
            string numberString = String.Empty;
            long result;
            int sign = 1;

            int i = 0;

            if (s == String.Empty)
            {
                return 0;
            }

            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }

            if (i < s.Length && s[i] == '-')
            {
                sign = -1;
                i++;
            }
            else if (i < s.Length && s[i] == '+')
            {
                i++;
            }

            if (i < s.Length && Char.IsDigit(s[i]))
            {
                while (i < s.Length && Char.IsDigit(s[i]))
                {
                    numberString += s[i];
                    i++;
                }
            }
            else
            {
                return 0;
            }

            numberString = numberString.TrimStart('0');

            if (sign > 0)
            {
                if (int.MaxValue.ToString().Length < numberString.Length)
                {
                    return int.MaxValue;
                }
            }
            if (sign < 0)
            {
                if (int.MinValue.ToString().Length < numberString.Length)
                {
                    return int.MinValue;
                }
            }

            if (long.TryParse(numberString, out result))
            {
                if (result * sign > int.MaxValue)
                {
                    return int.MaxValue;
                }
                if (result * sign < int.MinValue)
                {
                    return int.MinValue;
                }
                return (int)(result * sign);
            }

            return 0;
        }
    }
}
