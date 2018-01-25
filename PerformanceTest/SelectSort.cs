namespace PerformanceTest
{
    public class SelectSort
    {
        public static int[] Sort(int[] toBeSorted)
        {
            for (int i = 0; i < toBeSorted.Length; i++)
            {
                int currentLow = toBeSorted[i];
                int currentIndex = i;
                int j = i;

                while (j < toBeSorted.Length)
                {
                    if (currentLow > toBeSorted[j])
                    {
                        currentLow = toBeSorted[j];
                        currentIndex = j;
                    }
                    j++;
                }

                var tmp = toBeSorted[i];
                toBeSorted[i] = currentLow;
                toBeSorted[currentIndex] = tmp;
            }

            return toBeSorted;
        }
    }
}