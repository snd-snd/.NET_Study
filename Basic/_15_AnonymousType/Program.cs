using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_AnonymousTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new { Name = "홍길동", Age = 25, Score = 95 };

            Console.WriteLine("이름 : {0}", student.Name);
            Console.WriteLine("나이 : {0}", student.Age);
            Console.WriteLine("점수 : {0}", student.Score);
        }
    }
}
