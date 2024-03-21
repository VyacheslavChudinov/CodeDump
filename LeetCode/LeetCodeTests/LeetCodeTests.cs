

using Longest_Palindromic_Substring;
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
    }
}