using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LINQQueryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Source
            int[] numbers = { 5, 3, 8, 4, 1, 9, 2, 7, 6 };

            // Query Creation
            IEnumerable<int> numQuery = from num in numbers
                                        where (num % 2) == 0
                                        orderby num descending
                                        select num;

            // Query Execution
            foreach (var item in numQuery)
            {
                Console.Write(item + " "); // 8 6 4 2
            }

            Console.WriteLine();

            // Data Source
            List<string> list = new List<string>() { "kim", "lee", "park", "song", "choi" };

            // Query Creation
            var nameQuery = from name in list
                            where name.Contains("i")
                            select new { FirstName = name };

            // Query Execution
            foreach (var item in nameQuery)
            {
                Console.Write(item + " "); // { FirstName = kim } { FirstName = choi }
            }
            Console.WriteLine();

            // Data Source
            int[] numbers2 = { 5, 3, 8, 4, 1, 9, 2, 7, 6 };

            // Query Creation
            IEnumerable<int> numQuery2 = from num in numbers2
                                         let numnum = num + num + num
                                         select numnum;

            // Query Execution
            foreach (var item in numQuery2)
            {
                Console.Write(item + " "); // 8 6 4 2
            }
        }
    }
}
