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
                }
                else if (st.TryPeek(out char p) && parentheses[p] == s[i])
                {
                    st.Pop();
                }
                else
                {
                    return false;
                }
            }

            if (st.TryPeek(out char c))
            {
                return false;
            }

            return true;
        }
    }
}
