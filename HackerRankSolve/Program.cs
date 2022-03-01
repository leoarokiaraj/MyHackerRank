using System;

namespace HackerRankSolve
{
    public static class HackerRankSolve
    {
        public static void Main()
        {
            List<long> arr = new List<long>();
            arr.Add(256741038);
            arr.Add(623958417);
            arr.Add(467905213);
            arr.Add(714532089);
            arr.Add(938071625);
            miniMaxSum(arr);
               
        }

        public static void plusMinus(List<int> arr)
        {
            int positiveCount = 0, negativeCount = 0, zeroCount = 0;
            if (arr?.Count > 0)
            {
                foreach (var item in arr)
                {
                    if (item > 0)
                        positiveCount++;
                    else if (item < 0)
                        negativeCount++;
                    else
                        zeroCount++;
                }
                Console.WriteLine(String.Format("{0:0.000000}", (decimal)positiveCount / arr.Count));
                Console.WriteLine(String.Format("{0:0.000000}", (decimal)negativeCount / arr.Count));
                Console.WriteLine(String.Format("{0:0.000000}", (decimal)zeroCount / arr.Count));

            }
            else
            {
                Console.WriteLine(0.000000);
                Console.WriteLine(0.000000);
                Console.WriteLine(0.000000);
            }
           
        }

        public static void miniMaxSum(List<long> arr)
        {

            long minSum = 0, maxSum = 0;
            if (arr?.Count > 0)
            {
                minSum = maxSum = arr.Sum() - arr[0];
                for (int i = 1; i < arr.Count; i++)
                {
                    long sum = arr.Sum() - arr[i];
                    if (sum < minSum)
                        minSum = sum;

                    if (sum > maxSum)
                        maxSum = sum;
                }
            }
            Console.WriteLine(minSum.ToString() + " " + maxSum.ToString());

        }

    }
}