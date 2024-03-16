namespace Longest_Substring_Without_Repeating_Characters
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int Solve(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            if (s.Length == 1)
            {
                return 1;
            }

            var maxLength = 0;
            var startingIndex = 0;
            var currentCharSet = new HashSet<char>();

            for (var i = 0; i < s.Length; i++)
            {
                var hasCharacter = currentCharSet.Contains(s[i]);

                if (hasCharacter)
                {
                    if (currentCharSet.Count > maxLength)
                    {
                        maxLength = currentCharSet.Count;
                    }

                    var prevStartingIndex = startingIndex;
                    startingIndex = s.IndexOf(s[i], prevStartingIndex) + 1;

                    for (var j = prevStartingIndex; j < startingIndex; j++)
                    {
                        currentCharSet.Remove(s[j]);
                    }
                }

                currentCharSet.Add(s[i]);
            }

            return currentCharSet.Count > maxLength ? currentCharSet.Count : maxLength;
        }
    }
}
