using System.Text;

namespace LeetCodeTraining.GenerateParentheses
{
    //https://leetcode.com/problems/generate-parentheses/
    public static class GenerateParenthesesSolution
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            if (n == 1)
            {
                return new List<string>() { "()" };
            }

            StringBuilder sb;
            List<string> currentList = (List<string>)GenerateParenthesis(n - 1);
            HashSet<string> result = new HashSet<string>();

            foreach (string s in currentList)
            {
                for (int i = 0; i <= s.Length; i++)
                {
                    sb = new StringBuilder(s);
                    result.Add(sb.Insert(i, "()").ToString());
                }
            }

            return result.ToList<string>();
        }
    }
}
