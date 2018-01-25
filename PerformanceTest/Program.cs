// program to test performance of three sorting algorithms: bubble, insert and selection sorts
// first, generates a large set of random integers and times the various Sort() method calls
// perform again for increasingly larger array sizes

using System;
using System.Diagnostics;
using System.Linq;

namespace PerformanceTest
{
    class Program
    {
        static void Main()
        {
            var timer = new Stopwatch();
            long[] bsortTimes = new long[9];
            long[] isortTimes = new long[9];
            long[] ssortTimes = new long[9];

            // calculate number of ticks to sort increasingly larger arrays (from Length = 9 to 999999999)
            for (int i = 1; i <= 10; i++)
            {
                // array length defined as 9 per decimal place for each number of the iteration (e.g. 9, 99, 999, etc.)
                var arrayLength = (from j in Enumerable.Range(0, i) select 9 * (int)Math.Pow(10, j)).Sum();
                int[] toSort = ArrayOperations.GenerateIntegerArray(arrayLength);

                Console.WriteLine($"Integer Array generated, starting sorting algorithms for {arrayLength} items...");

                Console.Write("Bubble sorting... ");
                timer.Start();
                BubbleSort.Sort(toSort);
                timer.Stop();
                bsortTimes[i - 1] = timer.ElapsedTicks;
                Console.Write("Time (ticks): " + bsortTimes[i - 1]);
                Console.WriteLine();

                timer.Reset();

                Console.Write("Insertion Sorting...");
                timer.Start();
                InsertSort.Sort(toSort);
                timer.Stop();
                isortTimes[i - 1] = timer.ElapsedTicks;
                Console.Write("Time (ticks): " + isortTimes[i - 1]);
                Console.WriteLine();

                timer.Reset();

                Console.Write("Selection Sorting...");
                timer.Start();
                SelectSort.Sort(toSort);
                timer.Stop();
                ssortTimes[i - 1] = timer.ElapsedTicks;
                Console.Write("Time (ticks): " + ssortTimes[i - 1]);
                Console.WriteLine();
            }
        }
    }
}