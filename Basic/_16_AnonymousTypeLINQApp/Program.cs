using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_AnonymousTypeLINQApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new { Name = "홍길동", Age = 25, Score = 75 },
                new { Name = "박진우", Age = 27, Score = 92 },
                new { Name = "이호진", Age = 26, Score = 82 }
            };

            // LINQ Where Select를 이용해 점수가 80점 이상인 학생만 갖는 새 익명 타입 객체들을 리턴
            var list = students
                .Where(s => s.Score >= 80)
                .Select(s => new { Name = s.Name, Age = s.Age, Score = s.Score });

            foreach (var s in list)
                Console.WriteLine(s);
        }
    }
}
