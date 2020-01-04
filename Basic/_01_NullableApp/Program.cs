using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_NullableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int? value = null;

            if (value.HasValue)
                Console.WriteLine($"value : {value.Value}");
            else
                Console.WriteLine($"value는 null");
        }
    }
}
