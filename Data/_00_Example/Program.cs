using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ExampleDataContext db = new ExampleDataContext();

            var list = from i in db.Members
                       orderby i.Age descending
                       select i.Name;


            var list2 = db.Members.Where(s => s.Age == 29);

            foreach (var item in list2)
            {
                Console.WriteLine(item.Name);
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            var a = numbers.Where(s => s >= 5);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

        }
    }
}
