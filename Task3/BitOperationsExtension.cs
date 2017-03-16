using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Provides bit operations with decimal integers
    /// </summary>
    public static class BitOperationsExtension
    {
        #region Public members
        /// <summary>
        /// Implement the insert algorithm of one integer into the other, so that the other one will take the position from and up to the specified bits (the bits are numbered RTL)
        /// </summary>
        /// <param name="number1">Integer number for inserting the second number into it</param>
        /// <param name="number2">Integer number for inserting it into the first number</param>
        /// <param name="startPosition">Start position of insertation</param>
        /// <param name="endPosition">End position of insertation</param>
        /// <returns>New integer number, obtained by inserting bits of one source number into another</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int InsertByPosition(int number1, int number2, int startPosition, int endPosition)
        {
            if (startPosition > endPosition)
            {
                throw  new ArgumentException();
            }

            int[] number1Bin = TransformIntoBinary(number1);
            if (number1 < 0)
            {
                InvertBitsIfNegative(number1Bin);
            }
            int[] number2Bin = TransformIntoBinary(number2);
            if (number2 < 0)
            {
                InvertBitsIfNegative(number2Bin);
            }

            InsertBits(number1Bin, number2Bin, startPosition, endPosition);

            int result = TransformIntoDecimal(number1Bin);
            return number1 >= 0 ? result : -result;
        }
        #endregion

        #region Private members
        /// <summary>
        /// Transforms decimal number into binary
        /// </summary>
        /// <param name="number">Number to transform</param>
        /// <returns>Array of bits of the binary number</returns>
        static int[] TransformIntoBinary(int number)
        {
            int[] array = new int[32];

            if (number < 0)
            {
                number = -number;
            }

            int position = 31;
            for (; number > 0; number /= 2)
            {
                array[position--] = number % 2;
            }

            return array;
        }

        /// <summary>
        /// Transforms bits if the source number is negative
        /// </summary>
        /// <param name="array">Array of bits of binary number</param>
        static void InvertBitsIfNegative(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = Math.Abs(array[i] - 1);
            }

            int index = 31;
            while (true)
            {
                array[index]++;
                if (array[index] != 2)
                {
                    break;
                }
                index--;
            }
        }

        /// <summary>
        /// Inserts bits of one binary integer into the other, so that the other one will take the position from and up to the specified bits
        /// </summary>
        /// <param name="number1">Binary nteger number for inserting the second number into it</param>
        /// <param name="number2">Binary integer number for inserting it into the first number</param>
        /// <param name="startPosition">Start position of insertation</param>
        /// <param name="endPosition">End position of insertation</param>
        static void InsertBits(int[] number1, int[] number2, int startPosition, int endPosition)
        {
            int number2Index = 31;
            for (int i = endPosition; i >= startPosition; i--)
            {
                number1[31 - i] = number2[number2Index--];
            }
        }

        /// <summary>
        /// Transforms binary number into decimal
        /// </summary>
        /// <param name="array">Array of bits of the binary number</param>
        /// <returns>Decimal integer number</returns>
        static int TransformIntoDecimal(int[] array)
        {
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 1)
                {
                    number += (int) Math.Pow(2, 31 - i);
                }
            }

            return number;
        }

        #endregion
    }
}
