using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LINQFunctionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Source
            int[] numbers = { 5, 3, 8, 4, 1, 9, 2, 7, 6 };

            // Query Creation
            IEnumerable<int> numQuery = numbers
                .Where(num => (num % 2) == 0)
                .OrderByDescending(num => num);

            // Query Execution
            foreach (var item in numQuery)
            {
                Console.Write(item + " "); // 8 6 4 2
            }
            Console.WriteLine();

            // Data Source
            List<string> list = new List<string>() { "kim", "lee", "park", "song", "choi" };

            // Query Creation
            var nameQuery = list
                .Where(name => name.Contains("i"))
                .Select(name => new { FirstName = name });
       
            // Query Execution
            foreach (var item in nameQuery)
            {
                Console.Write(item + " "); // { FirstName = kim } { FirstName = choi }
            }
            Console.WriteLine();
        }
    }
}
