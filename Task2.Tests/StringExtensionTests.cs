using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2.Tests
{
    public class StringExtensionTests
    {

        [TestCase("xyaabbbccccdefww", "xxxxyyyyabklmopq", ExpectedResult = "abcdefklmopqwxy")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz",  ExpectedResult = "abcdefghijklmnopqrstuvwxyz")]
        [TestCase("zyxwvutsrqponmlkjihgfedcba", "abcdefghijklmnopqrstuvwxyz", ExpectedResult = "abcdefghijklmnopqrstuvwxyz")]
        [TestCase("a", "z", ExpectedResult = "az")]
        [TestCase("", "", ExpectedResult = "")]
        [TestCase("", "zaqwe", ExpectedResult = "aeqwz")]
        [TestCase("abc", "", ExpectedResult = "abc")]
        public string Concatenate_String1ConcatStrng2AndSortWithoutRepeatedSymbols(string string1, string string2)
        {
            return StringExtension.Concatenate(string1, string2);
        }

        [TestCase(null, null)]
        [TestCase(null, "hfsjdknksz")]
        [TestCase("sadfbgnfhgh", null)]
        public void Concatenate_ThrowsArgumentNullException(string string1, string string2)
        {
            Assert.Throws<ArgumentNullException>(() => StringExtension.Concatenate(string1, string2));
        }
    }
}
