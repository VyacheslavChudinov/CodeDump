namespace Reverse_Integer
{
    public static class ReverseInteger
    {
        public static string Limit = "2147483647"; // 7463847412
        public static bool Solve(int value)
        {

            return CheckIfExceedsLimit(value);

        }

        public static bool CheckIfExceedsLimit(int value)
        {
            var valueAsString = value.ToString();

            if (valueAsString.Length > Limit.Length)
            {
                return true;
            }

            if (valueAsString.Length == Limit.Length)
            {
                for (int i = 0; i < valueAsString.Length; i++)
                {
                    if (Limit[i] < valueAsString[valueAsString.Length - i - 1])
                    {
                        return true;
                    }
                }
                return false;
            }

            return false;
        }
    }
}
