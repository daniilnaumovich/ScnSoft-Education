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
            int currLength;
            int start;
            int end;

            for (int i = 0; i < 2 * s.Length - 2; i++)
            {
                start = i/2 - 1;

                if (i % 2 == 1)
                {
                    end = i/2 + 2;
                    currLength = 2;
                }
                else
                {
                    end = i/2 + 1;
                    currLength = 1;
                }

                if (i % 2 == 0 || (i % 2 == 1 && s[i/2 + 1] == s[i/2]))
                {
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
