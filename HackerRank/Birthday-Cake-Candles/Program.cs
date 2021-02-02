using System;
using System.Collections.Generic;
using System.Linq;

internal class Result
{
    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        int max = int.MinValue;
        int maxCount = 0;

        foreach (int x in candles)
        {
            if (x > max)
            {
                max = x;
                maxCount = 1;
            }
            else if (x == max)
                maxCount++;
        }

        return maxCount;
    }
}

namespace Birthday_Cake_Candles
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}