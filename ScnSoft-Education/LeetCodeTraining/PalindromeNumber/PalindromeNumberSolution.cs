namespace LeetCodeTraining.PalindromeNumber
{
    //https://leetcode.com/problems/palindrome-number/
    public static class PalindromeNumberSolution
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            string number = x.ToString();

            if (number.Length == 1)
            {
                return true;
            }

            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
