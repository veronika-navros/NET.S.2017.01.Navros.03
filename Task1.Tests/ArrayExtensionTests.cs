using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Task1.Tests
{
    public class ArrayExtensionTests
    {
        [TestCase(new[] {1, 2, 3, 4, 3, 2, 1}, ExpectedResult = 3)]
        [TestCase(new[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new[] { 0, 0, 0, 0, 0 }, ExpectedResult = 0)]
        [TestCase(new[] { 0, 1, 2 }, ExpectedResult = null)]
        public int? GetMiddleIndex_MiddleIndex(int[] array)
        {
            return ArrayExtension.GetMiddleIndex(array);
        }

        [TestCase(null)]
        public void GetMiddleIndex_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => ArrayExtension.GetMiddleIndex(array));
        }

        [TestCase(new int[] {})]
        public void GetMiddleIndex_ThrowsArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => ArrayExtension.GetMiddleIndex(array));
        }
    }
}
