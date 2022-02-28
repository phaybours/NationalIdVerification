using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class MonotonicArray
    {
        public static bool IsMonotonic(int[] array)
        {
            if (array.Length <= 2)
                return true;
            int direction = array[1] - array[0];
            for (int i = 2; i < array.Length; i++)
            {
                if(direction == 0)
                {
                    direction =  array[i] - array[i-1];
                    continue;
                }

                if(BreaksDirection(direction, array[i-1], array[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool BreaksDirection(int direction, int previous, int current)
        {
            var difference = current - previous;
            if(direction > 0) return difference < 0;
            return difference > 0;
        }

        public static bool IsMonotonic2(int[] array)
        {
            bool isMonotonicIncreasing = true;
            bool isMonotonicDecreasing = true;
            for(int i=1; i<array.Length; i++)
            {
                if(array[i] < array[i - 1])
                    isMonotonicIncreasing = false;
                if(array[i] > array[i-1])
                    isMonotonicDecreasing = false;
            }
            return isMonotonicIncreasing && isMonotonicDecreasing;
        }
    }
}
