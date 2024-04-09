

using Add_Two_Numbers;
using Longest_Palindromic_Substring;
using Longest_Substring_Without_Repeating_Characters;
using Median_of_Two_Sorted_Arrays;
using Reverse_Integer;
using Two_Sum;
using Longest_Common_Prefix;
using Valid_Parentheses;
using Remove_Duplicates_from_Sorted_Array;
using Merge_Two_Sorted_Lists;

namespace LeetCodeTests
{
    [TestClass]
    public class LeetCodeTests
    {
        [TestMethod]
        public void TestLongestPalindromicSubstring()
        {
            Assert.AreEqual(LongestPalindromicSubstring.Solve("a"), "a");
            Assert.IsTrue(LongestPalindromicSubstring.Solve("babad") == "bab" || LongestPalindromicSubstring.Solve("babad") == "aba");
            Assert.AreEqual(LongestPalindromicSubstring.Solve("cbbd"), "bb");
            Assert.AreEqual(LongestPalindromicSubstring.Solve("bb"), "bb");
        }

        [TestMethod]
        public void TestReverseInteger()
        {
            Assert.AreEqual(ReverseInteger.Solve(-2147483412), -2143847412);
            Assert.AreEqual(ReverseInteger.Solve(123), 321);
            Assert.AreEqual(ReverseInteger.Solve(2000000000), 2);
            Assert.AreEqual(ReverseInteger.Solve(2099999999), 0);
        }

        [TestMethod]
        public void TestMedianOfTwoSortedArrays()
        {
            Assert.AreEqual(FindMedianSortedArrays.Solve([1, 3], [2]), 2);
            Assert.AreEqual(FindMedianSortedArrays.Solve([1, 2], [3, 4]), 2.5);

        }

        [TestMethod]
        public void TestTwoSum()
        {
            CollectionAssert.AreEqual(TwoSum.Solve([2, 7, 11, 15], 9), new int[] { 0, 1 });
            CollectionAssert.AreEqual(TwoSum.Solve([3, 2, 4], 6), new int[] { 1, 2 });
            CollectionAssert.AreEqual(TwoSum.Solve([3, 3], 6), new int[] { 0, 1 });
        }

        [TestMethod]
        public void TestLongestSubstringWithoutRepeatingCharacters()
        {
            Assert.AreEqual(LongestSubstringWithoutRepeatingCharacters.Solve("abcabcbb"), 3);
            Assert.AreEqual(LongestSubstringWithoutRepeatingCharacters.Solve("bbbbb"), 1);
            Assert.AreEqual(LongestSubstringWithoutRepeatingCharacters.Solve("pwwkew"), 3);
        }

        [TestMethod]
        public void TestAddTwoNumbers()
        {
            var list1 = new Add_Two_Numbers.ListNode(2, new Add_Two_Numbers.ListNode(4, new Add_Two_Numbers.ListNode(3, null!)));
            var list2 = new Add_Two_Numbers.ListNode(5, new Add_Two_Numbers.ListNode(6, new Add_Two_Numbers.ListNode(4, null!)));

            Assert.AreEqual(list1.ToString(), "243");
            Assert.AreEqual(list2.ToString(), "564");
            Assert.AreEqual(AddTwoNumbers.Solve(list1, list2).ToString(), "708");
        }

        [TestMethod]
        public void TestLongestCommonPrefix()
        {

            Assert.AreEqual(LongestCommonPrefix.Solve(["flower", "flow", "flight"]), "fl");
            Assert.AreEqual(LongestCommonPrefix.Solve(["dog", "racecar", "car"]), "");
            Assert.AreEqual(LongestCommonPrefix.Solve(["", "flow", "flight"]), "");
        }

        [TestMethod]
        public void TestValidParentheses()
        {
            Assert.AreEqual(ValidParentheses.Solve("()"), true);
            Assert.AreEqual(ValidParentheses.Solve("()[]{}"), true);
            Assert.AreEqual(ValidParentheses.Solve("(]"), false);
            Assert.AreEqual(ValidParentheses.Solve("([)]"), false);
            Assert.AreEqual(ValidParentheses.Solve("]"), false);
        }

        [TestMethod]
        public void TestRemoveDuplicatesFromSortedArray()
        {
            Assert.AreEqual(RemoveDuplicatesFromSortedArray.Solve([1, 1, 2]), 2);
            Assert.AreEqual(RemoveDuplicatesFromSortedArray.Solve([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]), 5);
        }

        [TestMethod]
        public void TestMergeTwoSortedLists()
        {
            var firstTestList1 =
                new Merge_Two_Sorted_Lists.ListNode(1,
                new Merge_Two_Sorted_Lists.ListNode(2,
                new Merge_Two_Sorted_Lists.ListNode(4, null)));
            var firstTestList2 =
                new Merge_Two_Sorted_Lists.ListNode(1,
                new Merge_Two_Sorted_Lists.ListNode(3,
                new Merge_Two_Sorted_Lists.ListNode(4, null)));
            var firstTestList3 =
                new Merge_Two_Sorted_Lists.ListNode(1,
                new Merge_Two_Sorted_Lists.ListNode(1,
                new Merge_Two_Sorted_Lists.ListNode(2,
                new Merge_Two_Sorted_Lists.ListNode(3,
                new Merge_Two_Sorted_Lists.ListNode(4,
                new Merge_Two_Sorted_Lists.ListNode(4, null))))));

            Assert.AreEqual(MergeTwoSortedLists.Solve(firstTestList1, firstTestList2).ToString(), firstTestList3.ToString());
            Assert.AreEqual(MergeTwoSortedLists.Solve(null!, null!), null);
        }
    }
}
