namespace PerformanceTest
{
    public class InsertSort
    {
        public static int[] Sort(int[] toBeSorted)
        {
            for (int i = 1; i < toBeSorted.Length; i++)
            {
                int newValue = toBeSorted[i];
                int j = i;
				
                while (j > 0 && toBeSorted[j-1] > newValue)
                {
                    toBeSorted[j] = toBeSorted[j-1];
                    j--;
                }
				
                toBeSorted[j] = newValue;
            }

            return toBeSorted;
        }
    }
}