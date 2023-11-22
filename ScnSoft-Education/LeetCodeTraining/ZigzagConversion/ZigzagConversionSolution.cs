namespace LeetCodeTraining.ZigzagConversion
{
    //https://leetcode.com/problems/zigzag-conversion/
    public static class ZigzagConversionSolution
    {
        public static string Convert(string s, int numRows)
        {
            if (s.Length <= numRows || numRows == 1)
            {
                return s;
            }

            char[] result = new char[s.Length];
            int lookupIndex;
            int counter = 0;
            bool fromTop; // responsible for the way of calculating the next char

            for (int row = 0; row < numRows; row++)
            {
                lookupIndex = row;
                fromTop = true;

                while (true)
                {
                    result[counter] = s[lookupIndex];

                    CalculateIndeces(ref counter, ref lookupIndex, ref fromTop, row);

                    if (lookupIndex >= s.Length || counter >= s.Length)
                    {
                        break;
                    }
                }
            }

            return new string(result);

            void CalculateIndeces(ref int counter, ref int lookupIndex, ref bool fromTop, int row)
            {
                if (fromTop)
                {
                    counter++;
                    lookupIndex = lookupIndex + 2 * numRows - 2 * row - 2;
                    fromTop = false;
                }
                else
                {
                    if (lookupIndex % (numRows - 1) != 0)
                    {
                        counter++;
                    }

                    lookupIndex = lookupIndex + 2 * row;
                    fromTop = true;
                }
            }
        }
    }
}
