using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class NoFilters
    {
        public static int GetNoFilters(int[] A)
        {
            //int noFilters = 0;
            //int totalPolution = A.Sum(x => x);
            //int midPoint = totalPolution / 2;
            //int totalReduced = int.MaxValue;
            //var B = A.Clone() as int[];
            //while (totalReduced > midPoint)
            //{
            //    Array.Sort(B, new Comparison<int>((i, j) => j.CompareTo(i)));
            //    int v = (int)(Math.Ceiling((decimal)B[0] / 2));
            //    B[0] = v;
            //    totalReduced = B.Sum() / 2;
            //    noFilters++;
            //}
            //return noFilters;
            int noFilters = 0;
            int totalPolution = A.Sum(x => x);
            int midPoint = totalPolution / 2;
            int totalReduced = int.MaxValue;
            var B = A.Clone() as int[];
            while (totalReduced > midPoint)
            {
                Array.Sort(B, new Comparison<int>((i, j) => j.CompareTo(i)));
                //int v = (int)(Math.Ceiling((decimal)B[0] / 2));
                int v = B[0]/2;
                B[0] = v;
                totalReduced = B.Sum();
                noFilters++;
            }
            return noFilters;
        }
    }
}
