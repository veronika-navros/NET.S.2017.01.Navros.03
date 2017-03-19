using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task3.NUnitTests
{
    public class BitOperationsExtensionTests
    {
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
        [TestCase(15, 15, 1, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 1, 4, ExpectedResult = 15)]
        [TestCase(-8, -15, 1, 4, ExpectedResult = -6)]
        public int InsertByPosition_InsertBitsOfNumber2IntoNumber1(int number1, int number2, int startPosition, int endPosition)
        {
            return BitOperationsExtension.InsertByPosition(number1, number2, startPosition, endPosition);
        }

        [TestCase(8, 15, -1, 5)]
        [TestCase(8, 15, 5, -1)]
        [TestCase(8, 15, 31, 5)]
        [TestCase(8, 15, 7, 5)]
        [TestCase(8, 15, 1, 0)]
        public void InsertByPosition_ThrowsArgumentException(int number1, int number2, int startPosition, int endPosition)
        {
            Assert.Throws<ArgumentException>(
                () => BitOperationsExtension.InsertByPosition(number1, number2, startPosition, endPosition));
        }

    }
}
