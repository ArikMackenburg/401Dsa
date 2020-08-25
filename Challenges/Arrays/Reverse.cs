using System;
<<<<<<< HEAD

namespace Challenges.Arrays
{
    public class Reverse
=======
using System.Collections.Generic;
using System.Text;
using Challenges;

namespace Challenges.Arrays
{
    class Reverse
>>>>>>> master
    {
        public static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            int reverseSpot = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[reverseSpot] = array[i];
                reverseSpot--;
            }
            return reversedArray;
        } 
    }
}