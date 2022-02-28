using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public class FirstDuplicateValue
    {
        public static int GetFirstDuplicateValue(int[] array)
        {
            var tempList = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if(tempList.Add(array[i]))
                    return array[i];

                tempList.Add(array[i]);
            }
            return -1;
        }

        public static int GetFirstDuplicateValue2(int[] array)
        {
            int minIndex = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+ 1; j < array.Length; j++)
                {
                    if(array[j] == array[i])
                        minIndex = Math.Min(minIndex,j);
                }
            }
            if(minIndex == array.Length)
                return -1;

            return array[minIndex];
        }

        public static int GetFirstDuplicateValue3(int[] array)
        {
            foreach (int value in array)
            {
                int absoluteValue = Math.Abs(value);
                if (array[absoluteValue - 1] < 0)
                    return absoluteValue;

                array[absoluteValue - 1] *= -1;
            }
            return -1;
        }
    }
}
