using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Palindromic_Substring
{
    public static class LongestPalindromicSubstring
    {
        public static string Solve(string input)
        {
            var result = string.Empty;
            for (var i = 1; i < input.Length - 1; i++)
            {
                var subResult = string.Empty;

                for (var j = 1; j < input.Length - 2; j++)
                {
                    if (i - j < 0 || i + j > input.Length - 1) { break; }

                    if (input[i - j] == input[i + j])
                    {
                        subResult = input.Substring(i - j, j * 2 + 1);
                    }
                }

                if (subResult.Length > result.Length)
                {
                    result = subResult;
                }

            }


            return result;
        }

    }
}
