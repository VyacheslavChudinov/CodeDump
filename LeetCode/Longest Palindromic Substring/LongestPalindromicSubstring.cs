namespace Longest_Palindromic_Substring
{
    public static class LongestPalindromicSubstring
    {
        public static string Solve(string input)
        {
            var (resultLeft, resultRight) = (0, 0);

            for (var i = 0; i < input.Length - 1 && input.Length - i > resultRight - resultLeft; i++)
            {
                var (left, right) = FindLongestPalindromFromLeft(i, input.Length - 1, input);

                if (left != -1 && right != -1 && right - left > resultRight - resultLeft)
                {
                    resultLeft = left;
                    resultRight = right;
                }
            }


            return input.Substring(resultLeft, resultRight - resultLeft + 1);
        }

        private static (int, int) FindLongestPalindromFromLeft(int left, int right, string input)
        {

            for (var j = right; j > left; j--)
            {
                if (CheckIfPalindrome(left, j, input))
                {
                    return (left, j);
                }
            }

            return (-1, -1);
        }

        private static bool CheckIfPalindrome(int left, int right, string input)
        {
            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

    }
}
