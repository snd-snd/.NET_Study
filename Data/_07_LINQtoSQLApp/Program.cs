using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _07_LINQtoSQLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataDataContext db = new DataDataContext();

            // Members 테이블에 대한 레코드 객체 생성
            Members member1 = new Members();
            member1.Id = "choi123";
            member1.Password = "1234";
            member1.Name = "최씨";
            member1.Age = 10;

            // 레코드 객체를 테이블 객체에 추가
            db.Members.InsertOnSubmit(member1);
            // 변경된 사항을 서버에 전송
            db.SubmitChanges();

            // 수정할 레코드를 서버에서 Get
            var member2 = db.Members.Where(m => m.Id.Equals("choi123")).SingleOrDefault();

            if (member2 != null)
            {
                // 수정
                member2.Name = "최모씨";
                member2.Password = "552341";
                member2.Age = 120;
                db.SubmitChanges();
            }

            // 제거할 레코드를 서버에서 Get
            var member3 = db.Members.Where(m => m.Id.Equals("choi123")).SingleOrDefault();

            if (member3 != null)
            {
                // 제거
                db.Members.DeleteOnSubmit(member3);
            }

            // 제거할 레코드가 여러개일 경우
            var member4 = db.Members;
            db.Members.DeleteAllOnSubmit(member4);
            
            db.SubmitChanges();


            // 저장 프로시저 활용
            db.AddMember("kmss12", "4123", "케이", 66);
        }
    }
}
