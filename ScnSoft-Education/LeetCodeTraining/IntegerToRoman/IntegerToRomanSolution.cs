using System.Text;

namespace LeetCodeTraining.IntegerToRoman
{
    //https://leetcode.com/problems/integer-to-roman/
    public static class IntegerToRomanSolution
    {
        public static string IntToRoman(int num)
        {
            StringBuilder result = new StringBuilder();
            Dictionary<int, string> intToSymbol = new Dictionary<int, string>()
            {
                {1000,  "M"},
                {900,   "CM"},
                {500,   "D"},
                {400,   "CD"},
                {100,   "C"},
                {90,    "XC"},
                {50,    "L"},
                {40,    "XL"},
                {10,    "X"},
                {9,     "IX"},
                {5,     "V"},
                {4,     "IV"},
                {1,     "I"}
            };

            foreach (var rep in intToSymbol)
            {
                while (num >= rep.Key)
                {
                    num -= rep.Key;
                    result.Append(rep.Value);
                }
            }

            return result.ToString();
        }
    }
}
