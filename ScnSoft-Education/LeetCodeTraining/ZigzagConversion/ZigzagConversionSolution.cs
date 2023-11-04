namespace LeetCodeTraining.ZigzagConversion
{
    //https://leetcode.com/problems/zigzag-conversion/
    public static class ZigzagConversionSolution
    {
        public static string Convert(string s, int numRows)
        {
            char[] result = new char[s.Length];

            int lookupIndex;
            int counter = 0;

            if (s.Length <= numRows || numRows == 1)
            {
                return s;
            }

            for (int row = 0; row < numRows; row++)
            {
                lookupIndex = row;

                while (true)
                {
                    result[counter] = s[lookupIndex];
                    counter++;

                    lookupIndex = lookupIndex + 2 * numRows - 2 * row - 2;

                    if (lookupIndex >= s.Length || counter >= s.Length)
                    {
                        break;
                    }

                    result[counter] = s[lookupIndex];

                    if (lookupIndex % (numRows - 1) != 0)
                    {
                        counter++;
                    }

                    lookupIndex = lookupIndex + 2 * row;

                    if (lookupIndex >= s.Length || counter >= s.Length)
                    {
                        break;
                    }
                }
            }

            return new String(result);
        }
    }
}
