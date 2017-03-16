using System;

namespace Task2
{
    /// <summary>
    /// Provides extended capabilities for working with strings
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// For two strings including only the symbols from ‘a’ to ‘z’ concatenates them into result line excluding the repeated symbols and sorts it in the alphabetical order
        /// </summary>
        /// <param name="string1">The first string for concatenation</param>
        /// <param name="string2">The second string for concatenation</param>
        public static string ConcatenateByAlphabet(string string1, string string2)
        {
            if (string1 == null || string2 == null)
            {
                throw new NullReferenceException();
            }

            int i = 0, j = 0;
            string result = "";

            while (i < Math.Min(string1.Length, string2.Length) && i < Math.Min(string1.Length, string2.Length))
            {
                if (string1[i] > 'z' || string1[i] < 'a' || string2[i] < 'a' || string2[i] > 'z')
                {
                    throw new ArgumentException();
                }

                if (string1[i] < string2[i])
                {
                    result += string1[i++];
                }
                else
                {
                    result += string2[i++];
                }
            }

            for (i = 1; i < result.Length; i++)
            {
                if (result[i] == result[i - 1])
                {
                    result.Remove(i, 1);
                    i--;
                }
            }

            return result;
        }
    }
}
