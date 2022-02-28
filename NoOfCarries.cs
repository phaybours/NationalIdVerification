using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class NoOfCarries
    {
        public static (int, string) GetNoOfCarries(int a, int b)
        {
            string sA = a.ToString(), sB = b.ToString();
            int carryCount = 0, carry = 0;
            string result = string.Empty;
            int lA = sA.Length, lB = sB.Length, iterateLimit = lA > lB ? lA : lB;
            for( int i = iterateLimit; i >=0; i--)
            {
                lA--; lB--;
                string cr1 = lA >= 0 ? sA[lA].ToString() : "0",
                cr2 = lB >= 0 ? sB[lB].ToString(): "0";

                int sum = int.Parse(cr1) + int.Parse(cr2) + carry;
                if(sum > 9)
                {
                    var sumString = sum.ToString();
                    carry = int.Parse(sumString[0].ToString());
                    result = sumString[1] + result;
                    carryCount++;
                }
                else
                {
                    result = sum + result;
                }
            }
            return (carryCount, result);
        }
    }
}
