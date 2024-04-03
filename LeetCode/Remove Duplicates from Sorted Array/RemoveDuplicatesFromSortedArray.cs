namespace Remove_Duplicates_from_Sorted_Array
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int Solve(int[] nums)
        {

            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;

            var insertPosition = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[insertPosition - 1])
                {
                    continue;
                }
                else
                {
                    nums[insertPosition] = nums[i];
                    insertPosition++;
                }
            }

            return insertPosition;
        }
    }
}
