using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class MergeTwoSortedArrays
    {
        public static int[] Merge(int[] first, int[] second)
        {
            int n1 = first.Length;
            int n2 = second.Length;
            int[] result = new int[n1 + n2];
            int i = 0, j = 0, k=0;

            while(i < n1 && j < n2)
            {
                if(first[i] < second[j])
                {
                    result[k++] = first[i++];
                }
                else
                {
                    result[k++] = second[j++];
                }
            }

            while (i < n1)
            {
                result[k++] = first[i++];
            }
            while (j < n2)
            {
                result[k++] = second[j++];
            }
            return result;
        }

        public static int[] Merge(int[] first, int[] second,int m, int n)
        {
            var ouput = new int[m + n];
            int i = 0, j = 0;
            int k = m < n ? n - 1 : m - 1;
            while (i <= k && j < m)
            {
                if (first[i] < second[j])
                    i++;
                else
                {
                    int temp = second[j];
                    second[j] = first[k];
                    first[k] = temp;
                    j++;
                    k--;
                }
            }
            Array.Sort(first);
            Array.Sort(second);

            Array.Copy(first, ouput, m);
            Array.Copy(second, 0, ouput, m, n);

            return ouput;
        }
    }
}
