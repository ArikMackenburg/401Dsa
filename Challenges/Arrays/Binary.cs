using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Arrays
{
    public class Binary
    {
        public static int BinarySearch(int[] arr, int search)
        {
            int result = -1;
            int mid = arr.Length / 2;
            if ( search == arr[mid])
            {
                result = mid;
                return result;
            }
            if ( search < arr[mid] )
            {
                for (int i = mid; mid > 0; i--)
                {
                    if (arr[i] == search)
                    {
                        result = i;
                        return result;
                    }
                    
                }
            }
            if (search > arr[mid] )
            {
                for ( int i = mid; i < arr.Length; i++ )
                {
                    if (arr[i] == search)
                    {
                        result = i;
                        return result;
                    }
                    
                }
            }
            return result;
        }
    }
}
