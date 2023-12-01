namespace LeetCodeTraining.SubstringPermutation
{
    //https://leetcode.com/problems/substring-with-concatenation-of-all-words/
    public static class SubstringPermutationSolution
    {
        public static IList<int> FindSubstring(string s, string[] words)
        {
            Dictionary<string, int> freqStandard = new Dictionary<string, int>();
            Dictionary<string, int> freqEntry = new Dictionary<string, int>();
            IList<int> result = new List<int>();
            bool isResultEntry = true;
            string sub;

            for (int i = 0; i < words.Length; i++)
            {
                if (freqStandard.ContainsKey(words[i]))
                {
                    freqStandard[words[i]]++;
                    continue;
                }

                freqStandard.Add(words[i], 1);
                freqEntry.Add(words[i], 0);
            }

            for (int i = 0; i < s.Length - words.Length * words[0].Length + 1; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    sub = s.Substring(i + j * words[0].Length, words[0].Length);

                    if (freqEntry.ContainsKey(sub))
                    {
                        freqEntry[sub]++;
                        continue;
                    }

                    break;
                }

                foreach (var pair in freqEntry)
                {
                    if (freqEntry[pair.Key] < freqStandard[pair.Key])
                    {
                        isResultEntry = false;
                        break;
                    }
                }

                if (isResultEntry)
                {
                    result.Add(i);
                }

                foreach (var pair in freqEntry)
                {
                    freqEntry[pair.Key] = 0;
                }

                isResultEntry = true;
            }

            return result;
        }
    }
}
