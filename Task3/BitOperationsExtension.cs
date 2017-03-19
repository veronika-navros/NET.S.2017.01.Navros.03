using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

            if (startPosition < 0 || startPosition > 31 || endPosition < 0 || endPosition > 31)
            {
                throw new ArgumentException();
            }

            BitArray number1Bin = new BitArray(new[] { number1 });
            BitArray number2Bin = new BitArray(new [] { number2 });

            int i = 0;
            for (int j = startPosition; j <= endPosition; j++)
            {
                number1Bin[j] |= number2Bin[i++];
            }

            int[] result = new int[1];
            number1Bin.CopyTo(result, 0);
            return result[0];
        }
        #endregion
    }
}
