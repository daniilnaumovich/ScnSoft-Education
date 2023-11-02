using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTraining.PalindromeNumber
{
    //https://leetcode.com/problems/palindrome-number/
    public static class PalindromeNumberSolution
    {
        public static bool IsPalindrome(int x)
        {
            if (x <= 0 || x % 10 == 0)
            {
                return false;
            }

            List<int> orders = new List<int>();
            int res = 0;

            while (x != 0)
            {
                res = x % 10;
                orders.Add(res);
                x = x / 10;
            }

            for (int i = 0; i < orders.Count / 2; i++)
            {
                if (orders[i] != orders[orders.Count - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
