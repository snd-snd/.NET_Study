using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OptionalParameterApp
{
    class Program
    {
        static void OptionalMEthod(int a, int b = 100)
        {
            Console.WriteLine($"a : {a}");
            Console.WriteLine($"b : {b}");
        }
        static void Main(string[] args)
        {
            OptionalMEthod(200);
        }
    }
}
