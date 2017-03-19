using System;
using System.Linq;

namespace Task1
{
    /// <summary>
    /// Provides extended capabilities for working with arrays
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Searches for index of element the sum of elements of which on the left in the array equals that on the right.
        /// </summary>
        /// <param name="array">Source array where ti serch the specified index for</param>
        /// <returns>Index of element the sum of elements of which on the left in the array equals that on the right.</returns>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static int? GetMiddleIndex(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            if (!array.Any() || array.Length > 1000)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0, rightSum = 0;
                
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if (leftSum == rightSum)
                {
                    return i;
                }
            }

            return null;
        }
    }
}
