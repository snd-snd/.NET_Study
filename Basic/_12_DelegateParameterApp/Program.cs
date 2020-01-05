using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_DelegateParameterApp
{
    class Program
    {
        public delegate int Compare(int a, int b);
        public static int AscendingCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a > b) return -1;
            return 0;
        }
        public static int DescendingCompare(int a, int b)
        {
            if (a > b) return 1;
            else if (a < b) return -1;
            return 0;
        }
        public static void SelectionSort(ref int[] arr, Compare compare)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (compare(arr[i], arr[j]) == 1)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 9, 2, 3, 6, 7, 4 };
          
            SelectionSort(ref arr, new Compare(AscendingCompare));
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();

            SelectionSort(ref arr, new Compare(DescendingCompare));
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
