using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NamedParameterApp
{
    class Program
    {
        static void Print(string name, int age, int score)
        {
            Console.WriteLine($"name : {name}");
            Console.WriteLine($"age : {age}");
            Console.WriteLine($"score : {score}");
        }

        static void Main(string[] args)
        {
            Print(name: "김태호", age: 28, score: 100);
        }
    }
}
