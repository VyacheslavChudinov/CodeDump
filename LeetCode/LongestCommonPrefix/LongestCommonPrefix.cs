namespace Longest_Common_Prefix
{
    public static class LongestCommonPrefix
    {
        public static string Solve(string[] input)
        {

            if (input.Length == 0)
            {
                return string.Empty;
            }

            if (input.Length == 1)
            {
                return input[0];
            }

            var charIndex = 0;

            while (true)
            {
                if (string.IsNullOrEmpty(input[0]))
                {
                    return string.Empty;
                }

                if (charIndex > input[0].Length - 1)
                {
                    return input[0];
                }

                var charBuff = input[0][charIndex];

                for (var i = 1; i < input.Length; i++)
                {
                    if (charIndex > input[i].Length - 1 || string.IsNullOrEmpty(input[i]) || input[i][charIndex] != charBuff)
                    {
                        return input[0].Substring(0, charIndex);
                    }
                }

                charIndex++;
            }
        }
    }
}
