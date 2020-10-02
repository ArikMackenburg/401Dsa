using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace Challenges.Arrays
{
    public class Sorts
    {
        public static int[] InsertionSort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while(j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }
        public static int[] MergeSort(int[] arr)
        {
            int n = arr.Length;
            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                for(int i = 0; i< left.Length;i++)
                {
                    left[i] = arr[i];
                }
                
                int[] right = new int[n-mid];
                int j = mid;
                for (int i = 0; i < right.Length;i++)
                {
                    right[i] = arr[j++];
                }
                left = MergeSort(left);
                right = MergeSort(right);
                arr = Merge(left, right, arr);
            }
            return arr;
        }
        private static int[] Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while(i<left.Length && j<right.Length)
            {
                if(left[i] <= right[j])
                {
                    arr[k] = left[i++];
                }
                else
                {
                    arr[k] = right[j++];
                }
                k++;
            }
            if(i == left.Length)
            {
                while(k<arr.Length)
                {
                    arr[k++] = right[j++];
                }
            }
            else
            {
                while (k < arr.Length)
                {
                    arr[k++] = left[i++];
                }

            }
            return arr;
        }
        public static int[] QuickSort(int[] arr, int left, int right)
        {
            if(left<right)
            {
                int position = Partition(arr, left, right);
                QuickSort(arr, left, position - 1);
                QuickSort(arr, position + 1, right);
            }
            return arr;
        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left;
            for(int i = left; i < right; i++)
            {
                if(arr[i] < pivot)
                {
                    Swap(arr, i, low);
                    low++;

                }
            }
            Swap(arr, right, low);
            return low;
        }

        private static int[] Swap(int[]arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
            return arr;
        }
    }
}
