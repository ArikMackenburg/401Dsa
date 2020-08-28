using System;
using System.Text;

namespace Challenges.Arrays
{
    public class Shift
    {
        public static int[] ShiftArray(int[] array, int num)
        {
            int[] shiftedArray = new int[array.Length + 1];
            int mid = shiftedArray.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                shiftedArray[i] = array[i];
            }
            shiftedArray[mid] = num;
            for (int i = mid+1; i < shiftedArray.Length; i++ )
            {
                shiftedArray[i] = array[i - 1];
            }
            return shiftedArray;
        }
    }
}
