using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_DynamicKeywordApp
{
    class Program
    {
        // 매개변수 활용가능
        static void Print(dynamic obj)
        {
            // 동적언어로 런타임시 체크 (obj 객체에 Name, Age, Score가 없다면 예외발생)
            try
            {
                Console.WriteLine("obj.Name: {0}", obj.Name);
                Console.WriteLine("obj.Age: {0}", obj.Age);
                // Main 함수에서 Print 호출시 Score 속성은 할당하지 않았기에 예외발생
                Console.WriteLine("obj.Age: {0}", obj.Score);
            }
            catch (Exception e)
            {
                Console.WriteLine("예외발생: {0}", e.Message);
            }
        }

        static void Main(string[] args)
        {
            dynamic d1;

            // 중간에 다른 타입의 값을 할당할 수 있다.
            d1 = "문자열";
            d1 = 100;

            // dynamic 타입은 캐스팅이 필요없다.
            d1 += " 런타임 체크";

            Console.WriteLine(d1);

            Print(new { Name = "홍길동", Age = 20 });
        }
    }
}
