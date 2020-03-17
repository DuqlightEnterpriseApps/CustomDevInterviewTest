using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview.Tests
{
    [TestClass]
    public class InterviewTests
    {
        private Interview.Core.Interview _interview;

        [TestInitialize]
        public void Initialize()
        {
            _interview = new Interview.Core.Interview();
        }

        [TestMethod]
        public void TotalEvenNumbers_Should_Return_Sum_Of_All_Even_Numbers()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            long expected = 72;

            long result = _interview.TotalEvenNumbers(input);
            Assert.IsTrue(result.Equals(expected));
        }

        [TestMethod]
        public void ReverseString_Should_Reverse_Input()
        {
            string startValue = "abcdefghijklmnop";
            string expected = "ponmlkjihgfedcba";

            string result = _interview.ReverseString(startValue);
            Assert.IsTrue(result.Equals(expected));
        }


        [TestMethod]
        public void ReverseWords_Should_Reverse_Each_Word()
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            string expected = "ehT kciuq nworb xof spmuj revo eht yzal god";

            string result = _interview.ReverseWords(sentence);
            Assert.IsTrue(result.Equals(expected));
        }


        [TestMethod]
        public void ReverseWordOrder_Should_Reverse_Words()
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            string expected = "dog lazy the over jumps fox brown quick The";

            string result = _interview.ReverseWordOrder(sentence);
            Assert.IsTrue(result.Equals(expected));
        }

        [TestMethod]
        public void ReverseWordsAndOrder_Should_Reverse_Words_And_Reverse_Each_Word()
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            string expected = "god yzal eht revo spmuj xof nworb kciuq ehT";

            string result = _interview.ReverseWordsAndOrder(sentence);
            Assert.IsTrue(result.Equals(expected));
        }
    }
}
