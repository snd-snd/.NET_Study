using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_IndexserApp
{
    class Example
    {
        private const int MAX = 10;
        private int[] data = new int[MAX];

        public int this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example();

            ex[1] = 100;

        }
    }
}
