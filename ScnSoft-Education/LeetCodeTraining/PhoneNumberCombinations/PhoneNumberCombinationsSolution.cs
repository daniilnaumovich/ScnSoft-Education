using System.Text;

namespace LeetCodeTraining.PhoneNumberCombinations
{
    //https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    public static class PhoneNumberCombinationsSolution
    {
        public static IList<string> LetterCombinations(string digits)
        {
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

            if (digits.Length == 0)
            {
                return new string[] { };
            }

            List<string> output = new List<string>();
            if (numberToChar.ContainsKey(digits[^1]))
            {
                foreach (char c in numberToChar[digits[^1]])
                {
                    output.Add(c.ToString());
                }

                if (digits.Length == 1)
                {
                    return output;
                }
            }
            else
            {
                return output;
            }

            for (int i = digits.Length - 2; i >= 0; i--)
            {
                if (numberToChar.ContainsKey(digits[i]))
                {
                    AppendLettersOfDigit(output, numberToChar[digits[i]]);
                }
                else
                {
                    return output;
                }
            }

            return output;
        }

        public static List<string> AppendLettersOfDigit(List<string> input, string chars)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < chars.Length - 1; j++)
                {
                    input.Insert(i, input[i]);
                }
            }

            for (int k = 0; k < input.Count; k++)
            {
                builder.Append(input[k]);
                builder.Insert(0, chars[k % chars.Length]);
                input[k] = builder.ToString();
                builder.Clear();
            }

            return input;
        }
    }
}
