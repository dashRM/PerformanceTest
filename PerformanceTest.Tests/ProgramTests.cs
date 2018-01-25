using NUnit.Framework;

namespace PerformanceTest.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void GenerateIntegerArrayGeneratesProperLengthArrays()
        {
            // create arrays of varying length to test GenerateIntegerArray
            int[] testArrayLengths = {0, 1, 9, 999, 999999, 999999999};
            
            // call GenerateIntegerArray for each length
            for (int i = 0; i < testArrayLengths.Length; i++)
            {
                int[] testAray = ArrayOperations.GenerateIntegerArray(i);

                if (testAray.Length != i)
                    Assert.Fail($"Array incorrect length: {testAray.Length} for {i}!!!");
            }
            Assert.Pass();
        }

        [Test]
        public void BubbleSortTest()
        {
            int[] testArray = ArrayOperations.GenerateIntegerArray(999);
            int[] bubbleSortedArray = BubbleSort.Sort(testArray);
            
            // iterate across sorted array, verifying that it is less than or equal to the next item in the array
            for (int i = 0; i < testArray.Length - 1; i++)
            {
                if (!(bubbleSortedArray[i] <= bubbleSortedArray[i+1]))
                    Assert.Fail($"Array at position {i} has failed validation for Bubble Sort!!!");
            }
            Assert.Pass();
        }

        [Test]
        public void InsertSortTest()
        {
            int[] testArray = ArrayOperations.GenerateIntegerArray(999);
            int[] insertSortedArray = InsertSort.Sort(testArray);
            
            // iterate across sorted array, verifying that it is less than or equal to the next item in the array
            for (int i = 0; i < testArray.Length - 1; i++)
            {
                if (!(insertSortedArray[i] <= insertSortedArray[i+1]))
                    Assert.Fail($"Array at position {i} has failed validation for Insert Sort!!!");
            }
            Assert.Pass();
        }

        [Test]
        public void SelectSortTest()
        {
            int[] testArray = ArrayOperations.GenerateIntegerArray(999);
            int[] selectSortedArray = InsertSort.Sort(testArray);
            
            // iterate across sorted array, verifying that it is less than or equal to the next item in the array
            for (int i = 0; i < testArray.Length - 1; i++)
            {
                if (!(selectSortedArray[i] <= selectSortedArray[i+1]))
                    Assert.Fail($"Array at position {i} has failed validation for Selection Sort!!!");
            }
        }
    }
}