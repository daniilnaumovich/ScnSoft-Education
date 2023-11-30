namespace LeetCodeTraining.IndexOfSubstring
{
    //https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
    public static class IndexOfSubstringSolution
    {
        public static int StrStr(string haystack, string needle)
        {
            bool isResult;

            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                isResult = true;

                for (int j = 0; j < needle.Length; j++)
                {
                    if (needle[j] != haystack[i + j])
                    {
                        isResult = false;
                        break;
                    }
                }

                if (isResult)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
