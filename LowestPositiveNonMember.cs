using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class LowestPositiveNonMember
    {
        public static int GetValue(int[] A)
        {
            var max = A.Max();
            if(max <= 0)
                return 1;

            var cVal = 1;
            while(cVal <= max)
            {
                if (Array.IndexOf(A, cVal) >= 0)
                {
                    cVal++;
                    continue;
                }

                return cVal;
            }
            return cVal + 1;
            
        }

        public static int GetValue2(int[] A)
        {
            Array.Sort(A);
            int min = A.Min();
            int max = A.Max();
            if (max <= 0)
                return 1;
            if (min > 1)
                return 1;

            int v = A.Aggregate(1, 
                (a, b) => b - a > 1 ? a : b 
                );
            return v+1;
        }
        
        public static int GetValue3(int[] A)
        {
            Array.Sort(A);
            var max = A.Max();
            if(max <=0)
                return 1;
            var res = Enumerable.Range(A.First(),
                                  A.Last() - A.First() + 1)
                           .Except(A).FirstOrDefault();
            return res == 0 ? max +1 : res;
        }

    }
}
