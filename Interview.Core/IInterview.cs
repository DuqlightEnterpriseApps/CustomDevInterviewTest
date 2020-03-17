using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Core
{
    private interface IInterview
    {
        /// <summary>
        /// A method to total all the values that are even numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        long TotalEvenNumbers(int[] input);

        /// <summary>
        /// A method that will reverse the letters in a string
        /// </summary>
        /// <param name="stringToBeReversed"></param>
        /// <returns></returns>
        string ReverseString(string stringToBeReversed);

        /// <summary>
        /// A method that will reverse the words in a string
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        string ReverseWords(string sentence);

        /// <summary>
        /// A method that will reverse the order of the words in a given string
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        string ReverseWordOrder(string sentence);

        /// <summary>
        /// A method that wil reverse the order of the words in a given string and reverse the characters in each word.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        string ReverseWordsAndOrder(string sentence)
    }
}
