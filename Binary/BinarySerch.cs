using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification.Binary
{
    public static class BinarySerch
    {
        public static (bool found, int item) FindItem(int[] array, int left, int right, int itemToFind)
        {
            if (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == itemToFind) { 
                    return (true, array[mid]); 
                }

                if (array[mid] < itemToFind) { 
                    FindItem(array, left, mid - 1, itemToFind); 
                }
                else { 
                    FindItem(array, mid + 1, right, itemToFind); 
                }
            }

            return (false, -1);
        }
    }
}
