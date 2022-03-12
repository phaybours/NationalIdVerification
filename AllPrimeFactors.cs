using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class AllPrimeFactors
    {
        public static List<int> GetAllPrimeFactors(int input)
        {
            if(input == 1)
                return new List<int>();

            var results = new List<int>();
            int i = 2;
            while(input >= i)
            {
                while(input % i ==0)
                {
                    results.Add(i);
                    input /= i;
                }
                i++;
            }

            return results;
        }

    }
}
