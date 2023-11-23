using System.Text;

namespace LeetCodeTraining.PhoneNumberCombinations
{
    //https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    public static class PhoneNumberCombinationsSolution
    {
        public static IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0)
            {
                return new List<string>();
            }

            List<string> output = new List<string>();
            Dictionary<char, string> numberToChar = new Dictionary<char, string>()
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"}
            };

            foreach (char c in numberToChar[digits[^1]])
            {
                output.Add(c.ToString());
            }

            if (digits.Length == 1)
            {
                return output;
            }

            for (int i = digits.Length - 2; i >= 0; i--)
            {
                AppendLettersOfDigit(numberToChar[digits[i]]);
            }

            return output;

            void AppendLettersOfDigit(string chars)
            {
                StringBuilder builder = new StringBuilder();

                for (int i = output.Count - 1; i >= 0; i--)
                {
                    for (int j = 0; j < chars.Length - 1; j++)
                    {
                        output.Insert(i, output[i]);
                    }
                }

                for (int k = 0; k < output.Count; k++)
                {
                    builder.Append(output[k]);
                    builder.Insert(0, chars[k % chars.Length]);
                    output[k] = builder.ToString();
                    builder.Clear();
                }
            }
        }
    }
}
