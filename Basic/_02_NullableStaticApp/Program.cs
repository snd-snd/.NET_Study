using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NullableStaticApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b = null;
            Console.WriteLine(Nullable.Equals<int>(a, b));

            double? c = 10.11;
            double? d = 10.110000;
            Console.WriteLine(Nullable.Compare<double>(c, d));
        }
    }
}
