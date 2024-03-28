namespace Add_Two_Numbers
{
    public static class AddTwoNumbers
    {
        public static ListNode Solve(ListNode l1, ListNode l2)
        {
            var resultList = new ListNode();
            var hasOverFlow = false;
            var currentL1Node = l1;
            var currentL2Node = l2;
            var currentResultNode = resultList;

            while (currentL1Node is not null || currentL2Node is not null || hasOverFlow)
            {
                var localSum = (currentL1Node?.val ?? 0) + (currentL2Node?.val ?? 0) + (hasOverFlow ? 1 : 0);

                hasOverFlow = localSum > 9;

                if (currentResultNode is not null)
                {
                    currentResultNode.val = hasOverFlow ? localSum % 10 : localSum;
                }


                if (currentL1Node?.next is not null || currentL2Node?.next is not null || hasOverFlow)
                {
                    if (currentResultNode is not null)
                    { 
                        currentResultNode.next = new ListNode();
                    }

                    currentResultNode = currentResultNode?.next;
                }

                currentL1Node = currentL1Node?.next;
                currentL2Node = currentL2Node?.next;
            }

            return resultList;
        }
    }
}
