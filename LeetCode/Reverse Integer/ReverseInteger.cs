using System.Text;

namespace Reverse_Integer
{
    public static class ReverseInteger
    {
        public static string PositiveLimit = "2147483647";
        public static string NegativeLimit = "2147483648";
        public static int Solve(int value)
        {

            var isNegative = value < 0;

            var valueAsString = isNegative ? (-value).ToString() : value.ToString();
            var isTooBigInReverse = CheckIfExceedsLimit(valueAsString, isNegative);


            if (isTooBigInReverse) { return 0; }
            var result = Reverse(valueAsString);

            return isNegative ? -result : result;
        }

        public static int Reverse(string value)
        {
            var result = new StringBuilder();
            for (int i = value.Length - 1; i >= 0; i--)
            {
                result.Append(value[i]);
            }

            return int.Parse(result.ToString());
        }
        public static bool CheckIfExceedsLimit(string value, bool isNegative)
        {
            var limit = isNegative ? NegativeLimit : PositiveLimit;

            if (value.Length > limit.Length)
            {
                return true;
            }

            if (value.Length == limit.Length)
            {
                var i = 0;
                while (i < value.Length && limit[i] == value[value.Length - i - 1])
                {
                    i++;
                }

                if (limit[i] < value[value.Length - i - 1])
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
