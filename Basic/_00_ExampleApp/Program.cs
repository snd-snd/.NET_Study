using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _00_ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> pre = s => s.Equals(10);

            Console.WriteLine(pre(11));


            
        }
    }
}
