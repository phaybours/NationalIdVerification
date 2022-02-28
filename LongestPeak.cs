using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class LongestPeak
    {
        public static int GetLongestPeak(int[] array)
        {
            int longestPeak = 0;
            int i = 1;
            while(i < array.Length - 1)
            {
                bool isPeak = array[i - 1] < array[i] && array[i] > array[i + 1];
                if (isPeak)
                {
                    i++; continue;
                }

                int leftIndex = i - 2;
                while (leftIndex >= 0 && array[leftIndex] < array[leftIndex + 1])
                    leftIndex -= 1;

                int rightIndex = i + 2;
                while(rightIndex < array.Length && array[rightIndex] < array[rightIndex -1])
                    rightIndex += 1;

                int currentPeakLength = rightIndex - leftIndex -1;
               if (currentPeakLength > longestPeak)
                    longestPeak = currentPeakLength;

                i = rightIndex;
            }
            return longestPeak;
        }
    }
}
