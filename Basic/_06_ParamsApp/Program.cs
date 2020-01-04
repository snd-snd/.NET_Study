using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ParamsApp
{
    class Program
    {
        static int Sum(params int[] values)
        {
            int sum = 0;
            foreach (int i in values)
                sum += i;
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Sum(1, 3, 4, 1, 2, 3, 4, 6);
            Console.WriteLine(sum);
        }
    }
}
