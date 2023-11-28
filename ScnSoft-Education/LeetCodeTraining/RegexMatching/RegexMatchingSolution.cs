namespace LeetCodeTraining.RegexMatching
{
    //https://leetcode.com/problems/regular-expression-matching/
    public static class RegexMatchingSolution
    {
        public static bool IsMatch(string s, string p)
        {
            int sLength = s.Length;
            int pLength = p.Length;
            int index = 0;
            bool firstCharAccepted = false;
            bool[,] map = new bool[pLength, sLength];

            while (index + 2 < pLength && p[index] != s[0] && p[index] != '.' && p[index + 1] == '*')
            {
                index += 2;
            }

            if (AreCompatible(index, 0))
            {
                map[index, 0] = true;

                if (index + 1 < pLength && p[index + 1] == '*')
                {
                    index++;
                    firstCharAccepted = true;
                    map[index, 0] = true;

                    if (index + 1 < pLength && AreCompatible(index + 1, 0))
                    {
                        map[index + 1, 0] = true;
                    }
                }

                index += 2;
            }
            else
            {
                return false;
            }

            while (index < pLength && p[index] == '*' && (index < 2 || map[index - 2, 0]))
            {
                map[index, 0] = true;

                if (firstCharAccepted && index + 1 < pLength && AreCompatible(index + 1, 0))
                {
                    index++;
                    map[index, 0] = true;

                    if (index + 1 < pLength && p[index + 1] == '*')
                    {
                        index++;
                        map[index, 0] = true;
                    }
                }

                index += 2;
            }

            for (int i = 1; i < sLength; i++)
            {
                for (int j = 1; j < pLength; j++)
                {
                    if ((map[j - 1, i - 1] && AreCompatible(j, i))
                        || (p[j] == '*' && map[j, i - 1] && AreCompatible(j, i))
                        || (p[j] == '*' && j > 1 && map[j - 2, i]))
                    {
                        map[j, i] = true;
                    }
                }
            }

            return map[pLength - 1, sLength - 1];

            bool AreCompatible(int pIndex, int sIndex)
            {
                if (s[sIndex] == p[pIndex] || p[pIndex] == '.')
                {
                    return true;
                }
                if (p[pIndex] == '*')
                {
                    return AreCompatible(pIndex - 1, sIndex);
                }

                return false;
            }
        }
    }
}
