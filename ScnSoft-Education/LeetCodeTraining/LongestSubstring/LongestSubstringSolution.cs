namespace LeetCodeTraining.LongestSubstring
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public static class LongestSubstringSolution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            if (s.Length == 1)
            {
                return 1;
            }

            int longestSubstringLength = 0;
            int currentSubstringLength = 0;

            Dictionary<char, int> usedCharacters = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (!usedCharacters.ContainsKey(s[j]))
                    {
                        usedCharacters.Add(s[j], j);
                        currentSubstringLength += 1;
                    }
                    else
                    {
                        usedCharacters.Clear();
                        if (currentSubstringLength > longestSubstringLength)
                        {
                            longestSubstringLength = currentSubstringLength;
                        }
                        currentSubstringLength = 0;
                        break;
                    }
                }
            }

            return longestSubstringLength;
        }
    }
}
