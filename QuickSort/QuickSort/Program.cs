using System;

namespace QuickSort
{
    class Program
    {
        static int Partition(int[] array, int left, int right)
        {
            int x = array[left];
            int i = left - 1;
            int j = right + 1;

            while (true) {
                while (array[++i] < x) ;
                while (array[--j] > x) ;

                if (i < j)
                {
                    int temp = array[i];

                    array[i] = array[j];
                    array[j] = temp;
                }
                else
                {
                    return j;
                }
            }
        }

        static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot );
                QuickSort(array, pivot + 1, right);
            }
        }

        static void Main(string[] args)
        {
            //int[] arr = { 6, 5, 4, 3, 2, 1, 9, 8, 7 };
            int[] arr = { 12, 45, 22, 1, 48, 1, 23, 4, 5, 79, 12, 7, 4, 2 };

            QuickSort(arr, 0, arr.Length - 1);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
