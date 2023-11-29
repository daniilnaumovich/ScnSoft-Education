namespace LeetCodeTraining.ValidParentheses
{
    //https://leetcode.com/problems/valid-parentheses/
    public static class ValidParenthesesSolution
    {
        public static bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();
            Dictionary<char, char> parentheses = new Dictionary<char, char>()
            {
                {'(', ')'},
                {'{', '}'},
                {'[', ']'}
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (parentheses.ContainsKey(s[i]))
                {
                    st.Push(s[i]);
                    continue;
                }

                if (st.TryPop(out char p) && parentheses[p] == s[i])
                {
                    continue;
                }
                
                return false;
            }

            if (st.Any())
            {
                return false;
            }

            return true;
        }
    }
}
