namespace Valid_Parentheses
{
    public static class ValidParentheses
    {
        public static bool Solve(string input)
        {
            char[][] allParentheses = { ['(', ')'], ['[', ']'], ['{', '}'] };
            var parenthesesStack = new List<char>(input.Length);

            foreach (var inputChar in input)
            {
                var canProceed = UpdateStackIfParentheses(inputChar, parenthesesStack, allParentheses);
                if (!canProceed)
                {
                    return false;
                }
            }

            return parenthesesStack.Count == 0;
        }

        public static bool UpdateStackIfParentheses(char inputChar, List<char> parenthesesStack, char[][] allParentheses)
        {
            foreach (var parentheses in allParentheses)
            {
                if (parenthesesStack.Count > 0 && inputChar == parentheses[1] && parenthesesStack[parenthesesStack.Count - 1] != parentheses[0])
                {
                    return false;
                }

                if (parenthesesStack.Count == 0 && inputChar == parentheses[1])
                {
                    return false;
                }

                if (inputChar == parentheses[0])
                {
                    parenthesesStack.Add(inputChar);

                    return true;
                }
                else if (inputChar == parentheses[1] && parenthesesStack.Count > 0 && parenthesesStack[parenthesesStack.Count - 1] == parentheses[0])
                {
                    parenthesesStack.RemoveAt(parenthesesStack.Count - 1);
                    return true;
                }
            }

            return true;
        }
    }
}
