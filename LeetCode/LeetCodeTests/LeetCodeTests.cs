

using Longest_Palindromic_Substring;
using Longest_Substring_Without_Repeating_Characters;
using Median_of_Two_Sorted_Arrays;
using Reverse_Integer;
using Two_Sum;

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
    }
}
