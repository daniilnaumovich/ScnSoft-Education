namespace LeetCodeTraining.ValidParentheses
{
    //https://leetcode.com/problems/valid-parentheses/
    public static class ValidParenthesesSolution
    {
        public static bool IsValid(string s)
        {
            Dictionary<char, char> parentheses = new Dictionary<char, char>()
            {
                {'(', ')'},
                {'{', '}'},
                {'[', ']'}
            };

            Stack<char> st = new Stack<char>();
            char current;

            for (int i = 0; i < s.Length; i++)
            {
                if (parentheses.ContainsKey(s[i]))
                {
                    st.Push(s[i]);
                }
                else if (st.TryPeek(out current) == true && parentheses[st.Peek()] == s[i])
                {
                    st.Pop();
                }
                else
                {
                    return false;
                }
            }

            if (st.TryPeek(out current) == true)
            {
                return false;
            }

            return true;
        }
    }
}
