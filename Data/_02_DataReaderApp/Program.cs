using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _02_SqlCommandApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 연결 정보
            string connString = "server = localhost,1433; database = data; uid=kkorison; pwd=1234;";
            string cmdText = "insert into Members (Id, Password, Name, Age) values (@p1, @p2, @p3, @p4)";

            // 자동 리소스 닫기 (코드 블럭 종료시점에 자동으로 리소스를 닫는다.)
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(cmdText, conn);

                // 리소스 열기
                conn.Open();

                // cmdText의 쿼리문을 동적으로 수정(변경)
                cmd.Parameters.AddWithValue("@p1", "park123");
                cmd.Parameters.AddWithValue("@p2", "1234");
                cmd.Parameters.AddWithValue("@p3", "박철민");
                cmd.Parameters.AddWithValue("@p4", 29);

                // 명령 실행
                cmd.ExecuteNonQuery();                
            }    
        }
    }
}
