using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region Hacher Rank "Problem Solving"
    class Result
    {
        #region Compare The Triplets
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> res = new List<int>();
            int[] result = new int[2];
            result[0] = 0;
            result[1] = 0;
            if (a.Count == b.Count)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] >= 1 && a[i] < 100 && b[i] >= 1 && b[i] < 100)
                    {
                        if (a[i] > b[i])
                        {
                            result[0] += 1;
                        }
                        else if (a[i] < b[i])
                        {
                            result[1] += 1;
                        }
                    }
                }
            }
            res.AddRange(result);
            return res;
        }
        #endregion

        #region A Very Big Sum
        public static long aVeryBigSum(List<long> ar)
        {
            long result = 0;

            if (ar.Count >= 1 && ar.Count <= 10)
            {
                for (int i = 0; i < ar.Count; i++)
                {
                    if (ar[i] >= 0 && ar[i] < 10000000000)
                    {
                        result += ar[i];
                    }
                }
            }

            return result;
        }
        #endregion

        #region Diagonal Difference
        public static int diagonalDifference(List<List<int>> arr)
        {
            int left = 0;
            int right = 0;
            int x = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i][i] >= -100 && arr[i][i] <= 100)
                {
                    left += arr[i][i];
                }
            }
            for (int i = (arr.Count-1); i > -1; i--)
            {
                if (arr[x][i] >= -100 && arr[i][i] <= 100)
                {
                    right += arr[x][i];
                }
                x++;
            }
            return Math.Abs(left - right);
        }
        #endregion
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacker Rank");
            Console.ReadKey();
        }
    }
}
