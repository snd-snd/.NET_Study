using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ConvertOperatorApp
{
    class Animal { }
    class Dog : Animal { }
    class Box { }
    class Program
    {
        static void Casting(Object obj)
        {
            Animal animal = obj as Animal;
            Box box = obj as Box;
            bool check = obj is Dog;

            Console.WriteLine("animal Type: {0}", animal?.GetType().Name);
            Console.WriteLine("box Type: {0}", box?.GetType().Name);
            Console.WriteLine("obj == Dog? {0}\n", check);
        }
        static void Main(string[] args)
        {
            Casting(new Dog());
            Casting(new Box());
        }
    }
}
