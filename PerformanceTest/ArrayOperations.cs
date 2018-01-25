using System;

namespace PerformanceTest
{
    public class ArrayOperations
    {
        public static int[] GenerateIntegerArray(int arrayLength)
        {
            int[] integerArray = new int[arrayLength];
            var randomizer = new Random();
            for (int i = 0; i < integerArray.Length; i++)
            {
                integerArray[i] = randomizer.Next(0, int.MaxValue);
            }

            return integerArray;
        }
    }
}