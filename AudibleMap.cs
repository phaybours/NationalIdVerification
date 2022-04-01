using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class AudibleMap
    {
        public static int CountGroups(List<string> input)
        {
            int groupCount = 0;
                for(int i=0; i<input.Count; i++)
                {
                    for(int j=0; j < input[i].Length; j++)
                    {
                        if(i != j)
                        {
                            if ( input[i][j] == '1' )
                            {
                                groupCount++;
                            }
                        }
                        
                    }
                }
            return groupCount;
        }
    }
}
