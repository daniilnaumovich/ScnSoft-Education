namespace LeetCodeTraining.RomanToInteger
{
    //https://leetcode.com/problems/roman-to-integer/
    public static class RomanToIntegerSolution
    {
        public static int RomanToInt(string s)
        {
            int result = 0;

            Dictionary<char, int> romanToArabic = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (romanToArabic[s[i + 1]] > romanToArabic[s[i]])
                {
                    result = result - romanToArabic[s[i]];
                }
                else
                {
                    result = result + romanToArabic[s[i]];
                }
            }

            result = result + romanToArabic[s[s.Length - 1]];

            return result;
        }
    }
}
