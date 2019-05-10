using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 37, 21, 3, 12, 1, 23 };
            Console.WriteLine("Hello, we are sorting this array");
            PrintArray(array);
            Sort(array);
            Console.WriteLine("After sorting, array looks like this");
            PrintArray(array);
            Console.ReadLine();
        }
        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void Sort(int[] array)
        {
            int heapSize = array.Length;
            BuildHeap(array);
            HeapSort(array);
        }
        public static void BuildHeap(int[] array)
        {
            int heapSize = array.Length;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                SiftDown(i, array);
            }
        }
        public static void SiftDown(int index, int[] arr)
        {
            int leftChildIndex = GetLeftChildIndex(index);
            int rightChildIndex = GetRightChildIndex(index);
            int heapSize = arr.Length;
            int maxIndex = -1;
            if (leftChildIndex >= heapSize && rightChildIndex >= heapSize)
            {
                return;
            }
            if (leftChildIndex < heapSize)
            {
                maxIndex = leftChildIndex;
            }

            if (maxIndex == -1 || rightChildIndex < heapSize && arr[rightChildIndex] > arr[leftChildIndex])
            {
                maxIndex = rightChildIndex;
            }
            if (arr[index] < arr[maxIndex])
            {
                int temp = arr[index];
                arr[index] = arr[maxIndex];
                arr[maxIndex] = temp;
                SiftDown(maxIndex, arr);
            }


        }
        public static void HeapSort(int[] array)
        {

        }

        public static int GetLeftChildIndex(int node)
        {
            return 2 * node + 1;
        }
        public static int GetRightChildIndex(int node)
        {
            return 2 * node + 2;
        }

    }
}