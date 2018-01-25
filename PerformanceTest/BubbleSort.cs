namespace PerformanceTest
{
    public class BubbleSort
    {
        public static int[] Sort(int[] toBeSorted)
        {
            bool isSwapped;

            do
            {
                isSwapped = false;

                for (int i = 0; i < toBeSorted.Length - 1; i++)
                {
                    if (toBeSorted[i] > toBeSorted[i + 1])
                    {
                        var temp = toBeSorted[i + 1];

                        toBeSorted[i + 1] = toBeSorted[i];
                        toBeSorted[i] = temp;
                        isSwapped = true;
                    }
                }
            } while (isSwapped);

            return toBeSorted;
        }
    }
}