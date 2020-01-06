using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_VarKeywordApp
{
    class Program
    {        
        static void Main(string[] args)
        {
            var v1 = 10;
            var v2 = "string";
            //var v3 = null;    null 초기화 불가
            //var? v4 = null;   Nullable 지정 불가
            Console.WriteLine("v1: {0}", v1);
            Console.WriteLine("v2: {0}", v2);

            v2 = null;       // 초기값(참조타입) 할당 후 null 할당은 가능
            //v2 = 100;         초기타입과 다른 타입의 값은 가질 수 없다.
            Console.WriteLine("v2: {0}", v2);

            string[] strs = new string[] { "apple", "banana", "melon", "peach" };

            // 반복문
            foreach (var s in strs)
                Console.WriteLine("string: {0}", s);

            // LINQ
            var res = from s in strs
                        where s.StartsWith("a")
                        select s;

            foreach (var s in res)
                Console.WriteLine("string: {0}", s);                
        }
    }
}
