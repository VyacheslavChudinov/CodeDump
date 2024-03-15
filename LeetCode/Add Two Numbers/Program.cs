using Add_Two_Numbers;

// 2 -> 4 -> 3
var list1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
var list2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));
Console.WriteLine(AddTwoNumbers.Solve(list1, list2).ToString());