using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_LambdaExpressionApp
{
    class Program
    {
        public delegate int Sum(int a, int b);
        static void Main(string[] args)
        {
            // 한줄로 작성 가능할 경우 리턴문, 중괄호 생략가능
            Sum sum = (a, b) => a + b;
            Console.WriteLine("10 + 20 = {0}", sum(10, 20));

            // 한줄로 작성하지 못할 경우 코드블럭내에 코드 작성
            Sum sum2 = (a, b) =>
            {
                int x = a;
                int y = b;
                return x + y;
            };
            Console.WriteLine("30 + 40 = {0}", sum2(30, 40));
        }
    }
}
