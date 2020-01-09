using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LINQCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 90, 92, 97, 88, 85, 71 };

            var top = from score in scores
                      select score;
                       

            foreach (var item in top)
            {
                Console.WriteLine(item);
            }
                      


        }
    }
}
