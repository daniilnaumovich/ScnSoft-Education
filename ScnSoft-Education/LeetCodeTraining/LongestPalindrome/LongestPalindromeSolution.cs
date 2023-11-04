namespace LeetCodeTraining.LongestPalindrome
{
    //https://leetcode.com/problems/longest-palindromic-substring/
    public static class LongestPalindromeSolution
    {
        public static string LongestPalindrome(string s)
        {
            string longestPalindromeSubstring = String.Empty;
            string currentSub = String.Empty;
            int startIndex;
            int endIndex;

            if (s.Length == 1)
            {
                return s;
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    if (j == 0)
                    {
                        currentSub = s[i].ToString();
                        startIndex = i;
                        endIndex = i;
                    }
                    else if (j == 1 && s[i + 1] == s[i])
                    {
                        currentSub = s[i].ToString() + s[i + 1].ToString();
                        startIndex = i;
                        endIndex = i + 1;
                    }
                    else
                    {
                        break;
                    }

                    while (startIndex - 1 >= 0 && endIndex + 1 < s.Length)
                    {
                        if (s[startIndex - 1] == s[endIndex + 1])
                        {
                            currentSub = $"{s[startIndex - 1]}{currentSub}{s[endIndex + 1]}";
                            startIndex = startIndex - 1;
                            endIndex = endIndex + 1;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentSub.Length > longestPalindromeSubstring.Length)
                    {
                        longestPalindromeSubstring = currentSub;
                    }
                }
            }

            return longestPalindromeSubstring;
        }
    }
}
