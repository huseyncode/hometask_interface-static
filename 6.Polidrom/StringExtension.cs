using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Polidrom
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string str)
        {
            int min = 0;
            int max = str.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = str[min];
                char b = str[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }

}
