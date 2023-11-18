namespace LeetCodeTraining.LongestPalindrome
{
    //https://leetcode.com/problems/longest-palindromic-substring/
    public static class LongestPalindromeSolution
    {
        public static string LongestPalindrome(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }

            int startIndex = 0;
            int maxLength = 0;
            int currLength = 0;
            int start;
            int end;

            for (int i = 0; i < s.Length - 1; i++)
            {
                currLength = 1;
                start = i - 1;
                end = i + 1;

                while (start >= 0 && end < s.Length && s[start] == s[end])
                {
                    currLength += 2;
                    start--;
                    end++;
                }

                if (currLength > maxLength)
                {
                    maxLength = currLength;
                    startIndex = start + 1;
                }

                currLength = 0;

                if (s[i + 1] == s[i])
                {
                    currLength = 2;
                    start = i - 1;
                    end = i + 2;

                    while (start >= 0 && end < s.Length && s[start] == s[end])
                    {
                        currLength += 2;
                        start--;
                        end++;
                    }

                    if (currLength > maxLength)
                    {
                        maxLength = currLength;
                        startIndex = start + 1;
                    }
                }
            }

            return s.Substring(startIndex, maxLength);
        }
    }
}
