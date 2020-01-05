using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_AnonymousMethodApp
{
    class Program
    {
        public delegate void Print(string msg);

        static void Main(string[] args)
        {
            // 대리자 인스턴스에 무명메서드를 할당
            Print print = delegate (string msg)
            {
                Console.WriteLine(msg);
            };
            print("무명 메서드");
        }
    }
}
