

using Longest_Palindromic_Substring;

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
    }
}