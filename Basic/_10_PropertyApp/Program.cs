using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PropertyApp
{
    class Human
    {
        // 변수
        private string name;
        // 프로퍼티
        public string Name
        {
            get
            {
                return this.name;
            }
            // 접근제한자 적용 가능
            internal set
            {
                this.name = value;
            }
        }
        // 자동 구현 프로퍼티 (변수 생략)
        public int Age { get; set; }
        // 선언과 동시 초기화 (C# 6.0)
        public int Score { get; set; } = 10;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = "김태호";
            human.Age = 29;
            Console.WriteLine(human.Score);
            // 객체 생성시 초기화 가능
            Human human2 = new Human() { Name = "핫산", Age = 20, Score = 100 };
        }
    }
}
