using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _01_ConnectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 연결 정보
            string connString = "server = localhost,1433; database = data; uid=kkorison; pwd=1234;";

            // 커넥션 연결
            SqlConnection conn = new SqlConnection(connString);

            // 리소스 열기
            conn.Open();
            Console.WriteLine(conn.State);
            // 리소스 열기
            conn.Close();
            Console.WriteLine(conn.State);

            // 자동 리소스 닫기 (코드 블럭 종료시점에 자동으로 리소스를 닫는다.)
            using (SqlConnection conn2 = new SqlConnection(connString))
            {
                conn2.Open();
            } 
        }
    }
}
