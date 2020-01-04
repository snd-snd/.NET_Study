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


        static void Main(string[] args)
        {
            int a = 100;
            RefMethod(ref a);
            Console.WriteLine(a);

            int b;
            OutMethod(out b);
            Console.WriteLine(b);
        }

    }
}
