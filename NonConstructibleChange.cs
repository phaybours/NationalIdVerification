using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class NonConstructibleChange
    {
        public static int GetNonConstructibleChange(int[] coins)
        {
            Array.Sort(coins);
            int currentChangeCreated = 0;
            foreach (int coin in coins)
            {
                if(coin > currentChangeCreated +1 )
                    return currentChangeCreated + 1;

                currentChangeCreated+=coin;
            }
            return currentChangeCreated+1;
        }
    }
}
