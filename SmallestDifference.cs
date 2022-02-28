using System;

namespace NationalIdVerification
{
    public static class SmallestDifference
    {
        public static int[] GetSmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int index1 = 0, index2 = 0, smallestDiff = int.MaxValue, currentDiff = int.MaxValue;
            int[] smallestPair = new int[2];
            while (index1 < arrayOne.Length && index2 < arrayTwo.Length)
            {
                int firstNumber = arrayOne[index1];
                int secondNumber = arrayTwo[index2];
                if (firstNumber < secondNumber)
                {
                    currentDiff = secondNumber - firstNumber;
                    index1 += 1;
                }
                else if (secondNumber < firstNumber)
                {
                    currentDiff = firstNumber - secondNumber;
                    index2 += 1;
                }
                else
                {
                    return new int[] { firstNumber, secondNumber };
                }

                if (smallestDiff > currentDiff)
                {
                    smallestDiff = currentDiff;
                    smallestPair = new int[2] { firstNumber, secondNumber };
                }
            }
            return smallestPair;
        }
    }
}
