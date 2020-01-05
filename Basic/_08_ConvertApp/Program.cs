using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ConvertApp
{
    class Program
    {
static void Main(string[] args)
{
    int a = 1433;
    string b = a.ToString();
    double c = Convert.ToDouble(b);

    Console.WriteLine($"a Type: {a.GetTypeCode()}, Value: {a}");
    Console.WriteLine($"b Type: {b.GetTypeCode()}, Value: {b}");
    Console.WriteLine($"c Type: {c.GetTypeCode()}, Value: {c}");
}
    }
}
