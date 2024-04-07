namespace Merge_Two_Sorted_Lists
{
    public class MergeTwoSortedLists
    {
        public static ListNode? Solve(ListNode list1, ListNode list2)
        {
            if (list1 is null && list2 is null)
            {
                return null;
            }

            var resultList = new ListNode();
            var currentList = list1;
            var buffList = list2;
            var resultCurrent = resultList;

            while (currentList is not null || buffList is not null)
            {
                if (currentList is null && buffList is not null
                        || (currentList is not null && buffList is not null && buffList.val <= currentList.val))
                {
                    (currentList, buffList) = (buffList, currentList);
                }

                resultCurrent.val = currentList!.val;
                currentList = currentList.next;

                if (currentList is not null || buffList is not null)
                {
                    resultCurrent.next = new ListNode();
                    resultCurrent = resultCurrent.next;
                }

            }

            return resultList;
        }
    }
}
