using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class BinaryGap
    {
        public static int GetBinaryGap(int n)
        {
            string binary = Convert.ToString(n,2);
            int longestGap = 0;

            binary = binary.Trim('0');
            foreach(var item in (string[])binary.Split('1'))
            {
                longestGap = Math.Max(longestGap, item.Length);
            }
            return longestGap;
        }
    }
}
