using System.Text;

namespace LeetCodeTraining.LongestCommonPrefix
{
    //https://leetcode.com/problems/longest-common-prefix/
    public static class LongestCommonPrefixSolution
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            StringBuilder prefix = new StringBuilder();
            string shortestWord = strs.ToList().OrderBy(x => x.Length).First();

            for (int i = 0; i < shortestWord.Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] != shortestWord[i])
                    {
                        return prefix.ToString();
                    }
                }

                prefix.Append(shortestWord[i]);
            }

            return prefix.ToString();
        }
    }
}
