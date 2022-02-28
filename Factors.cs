using System;
using System.Collections.Generic;
using System.Linq;

namespace NationalIdVerification
{
    public static class Factors
    {
        public static IEnumerable<decimal> GetFactors(decimal n)
        {
            var pairList = from i in Enumerable.Range(1, (int)(Math.Round(Math.Sqrt(Convert.ToDouble(n)) + 1)))
                           where n % i == 0
                           select new { A = i, B = n / i };

            foreach (var pair in pairList)
            {
                yield return pair.A; yield return pair.B;
            }
        }

        public static (decimal Impact, decimal Likelihood) GetPairs(decimal n)
        {
            decimal value = n;
            decimal impact = 1, likelihood = 1;
            if (n <= 3)
                (impact, likelihood)=(n, 1);
            if(n > 16)
            {
                (impact, likelihood) = (Math.Ceiling(n / 5), Math.Floor(n / 5));
            }
            else
            {
                if (IsPrime(n)) value -= 1;
                var result = GetFactors(value);
                var list = result.Where(x => x <= 5).OrderBy(x => x).ToList();
                for (int i = list.Count - 1; i > 0; i--)
                {
                    decimal curr = list[i], next = list[i - 1];
                    if ((curr * next == n) || (curr * next == (n - 1)))
                        (impact, likelihood) = (curr, next);
                }
            }
            return (impact, likelihood);
        }

        static bool IsPrime(decimal n)
        {
            if (n == 1) return false; if (n == 2) return true;
            var limit = Math.Ceiling(Math.Sqrt(Convert.ToDouble(n)));
            for (int i = 2; i <= limit; ++i)
                if (n % i == 0) return false;
            return true;
        }
    }
}
