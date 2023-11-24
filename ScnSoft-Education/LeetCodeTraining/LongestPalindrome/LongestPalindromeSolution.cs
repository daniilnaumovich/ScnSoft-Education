namespace LeetCodeTraining.LongestPalindrome
{
    //https://leetcode.com/problems/longest-palindromic-substring/
    public static class LongestPalindromeSolution
    {
        public static string LongestPalindromeAlternative(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }

            int startIndex = 0;
            int maxLength = 1;
            int currLength;
            int start;
            int end;

            for (int i = 0; i < s.Length - 1; i++)
            {
                start = i - 1;
                end = i + 1;
                currLength = 1;
                FindNewStartAndLength();

                if (s[i] == s[i + 1])
                {
                    start = i - 1;
                    end = i + 2;
                    currLength = 2;
                    FindNewStartAndLength();
                }
            }

            return s.Substring(startIndex, maxLength);

            void FindNewStartAndLength()
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

        public static string LongestPalindrome(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }

            int startIndex = 0;
            int maxLength = 0;  
            int index;
            int currLength;
            int start;
            int end;
            bool isDoubleCenter;

            for (int i = 0; i < 2 * s.Length - 2; i++)
            {
                index = i / 2;
                isDoubleCenter = i % 2 == 1;
                start = index - 1;

                if (isDoubleCenter)
                {
                    end = index + 2;
                    currLength = 2;
                }
                else
                {
                    end = index + 1;
                    currLength = 1;
                }

                if (!isDoubleCenter || (isDoubleCenter && s[index + 1] == s[index]))
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
