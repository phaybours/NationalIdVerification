using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class ArrayOfProducts
    {
        public static int[] GetArrayOfProducts(int[] array)
        {
            var resultList =  new List<int>();
            for (int i =0; i < array.Length; i++)
            {
                var arrayList = array.ToList();
                arrayList.RemoveAt(i);
                resultList.Add(arrayList.Aggregate((x, y) => x * y));
            }

            return resultList.ToArray();
        }

        public static int[] GetArrayProducts2(int[] array)
        {
            int[] products = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int product = 1;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j)
                        product *= array[j];
                    products[i] = product;
                }
            }
            return products;
        }
    }
}
