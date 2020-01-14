using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _00_ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "D:/test.txt";

            StreamReader reader = new StreamReader(path);

            StringBuilder sb = new StringBuilder();

            int flag = 1;

            while ((flag = reader.Read()) > 0)
            {
                sb.Append(Convert.ToChar(flag));
            }
            Console.WriteLine(sb.ToString());

            reader.Close();

            

            

            

        }
    }
}
