using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class MoveElementToEnd
    {
        public static List<int> DoMoveElementToEnd(List<int> array, int toMove)
        {
            int i = 0, j = array.Count - 1;
            while (i < j)
            {
                while(array[j] == toMove && i<j)
                    j--;

                if(array[i] == toMove)
                    (array[i], array[j]) = (array[j], array[i]);
                
                i++;
            }
            return array;
        }

        public static List<int> DoMoveElementToEnd2(List<int> array, int toMove)
        {
            int i = 0, j = array.Count - 1;
            while (i < j)
            {
                if (array[j] == toMove)
                {
                    j--;
                }
                else
                {
                    if (array[i] != toMove)
                    {
                        i++;
                    }
                    else if (array[i] == toMove && array[j] != toMove)
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                        i++;
                    }
                    else
                    {
                        j--;
                    }
                }

            }
            return array;
        }


    }
}
