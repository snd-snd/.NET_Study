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
            int? a = 10;

            double? b = a as int?;

            Console.WriteLine(b);



            
        }
    }
}
