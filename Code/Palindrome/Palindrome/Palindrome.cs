using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string input)
        {
            StringBuilder s = new StringBuilder(input);

            if (input.Length > 1)
            {
                if (string.Equals(input.Substring(0, 1), input.Substring(input.Length - 1, 1), StringComparison.InvariantCultureIgnoreCase))
                {
                    return IsPalindrome(input.Substring(1, input.Length - 2));
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

    }
}
