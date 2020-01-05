using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DelegateApp
{
    class Program
    {
        // 대리자 선언
        public delegate void Del(string msg);

        // 선언된 대리자와 호환되는 메서드
        public static void method1(string msg)
        {
            Console.WriteLine($"method1: {msg}");
        }
        public static void method2(string msg)
        {
            Console.WriteLine($"method2: {msg}");
        }
        static void Main(string[] args)
        {
            // 대리자 인스턴스 생성
            Del del;
            del = new Del(method1);
            del("메시지"); // method1: msg
            del = new Del(method2);
            del("메시지"); // method2: msg

            // 대리자에 복수의 메서드 전달
            Del del2 = new Del(method1);
            del2 += new Del(method2);
            del2.Invoke("메시지");
        }
    }
}
