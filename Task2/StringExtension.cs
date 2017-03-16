using System;
using System.Linq;

namespace Task2
{
    /// <summary>
    /// Provides extended capabilities for working with strings
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// For two strings including only the symbols from ‘a’ to ‘z’ concatenates them into result string excluding the repeated symbols and sorts it in the alphabetical order
        /// </summary>
        /// <param name="string1">The first string for concatenation</param>
        /// <param name="string2">The second string for concatenation</param>
        /// <returns>String consisting of two source strings sorted in alphabetical order without duplicated symbols</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static string Concatenate(string string1, string string2)
        {
            if (string1 == null || string2 == null)
            {
                throw new NullReferenceException();
            }

            char[] resultString = string.Concat(string1, string2).Distinct().ToArray();
            Array.Sort(resultString);

            return new string(resultString);
        }
    }
}
