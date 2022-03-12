using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class MedianOfTwoSortedArrays
    {
        public static double FindMedian(int[] first, int[] second)
        {
            double median;
            var merged = MergeTwoSortedArrays.Merge(first, second);
            int count = merged.Length;

            if (count % 2 == 0)
            {
                int middleElement1 = merged[(count / 2) - 1];
                int middleElement2 = merged[(count / 2)];
                median = (double)(middleElement1 + middleElement2) / 2;
            }
            else
            {
                median = merged[(count / 2)];
            }
            return median;
        }
    }
}
