using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ReferenceParamaterApp
{
    class Program
    {
        static void RefMethod(ref int value)
        {
            value = 1000;
        }

        static void OutMethod(out int value)
        {
            value = 1000;
        }

        public static void IntegerArrayModify(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 100;
            }
            int[] arr2 = { 5, 5, 5, 5, 5 };
            arr = arr2;
        }
        public static void Run()
        {
            int[] arr = { 1, 1, 1, 1, 1 };
            IntegerArrayModify(ref arr);
            // Console : 100 100 100 100 100
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int a = 100;
            RefMethod(ref a);
            Console.WriteLine(a);

            int b;
            OutMethod(out b);
            Console.WriteLine(b);

            Run();
        } 
    }
}
