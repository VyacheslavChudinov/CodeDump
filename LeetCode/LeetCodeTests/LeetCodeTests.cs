

using Longest_Palindromic_Substring;
using Median_of_Two_Sorted_Arrays;
using Reverse_Integer;

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
    }
}