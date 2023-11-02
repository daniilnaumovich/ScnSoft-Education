using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            StringBuilder longestString = new StringBuilder();
            string output = String.Empty;

            Dictionary<char, int> usedCharacters = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (!usedCharacters.ContainsKey(s[j]))
                    {
                        usedCharacters.Add(s[j], j);
                        longestString.Append(s[j]);
                    }
                    else
                    {
                        usedCharacters.Clear();
                        if (longestString.ToString().Length > output.Length)
                        {
                            output = longestString.ToString();
                        }
                        longestString = new StringBuilder();
                        break;
                    }
                }
            }

            return output.Length;
        }
    }
}
