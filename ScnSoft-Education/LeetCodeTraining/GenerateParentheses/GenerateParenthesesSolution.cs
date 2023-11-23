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

            StringBuilder sb = new StringBuilder();
            List<string> currentList = (List<string>)GenerateParenthesis(n - 1);
            HashSet<string> result = new HashSet<string>();

            foreach (string s in currentList)
            {
                for (int i = 0; i <= s.Length; i++)
                {
                    sb.Append(s);
                    result.Add(sb.Insert(i, "()").ToString());
                    sb.Clear();
                }
            }

            return result.ToList();
        }
    }
}
