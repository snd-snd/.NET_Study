using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _03_DataReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 연결 정보
            string connString = "server = localhost,1433; database = data; uid=kkorison; pwd=1234;";
            string cmdText = "select * from Members";

            // 자동 리소스 닫기 (코드 블럭 종료시점에 자동으로 리소스를 닫는다.)
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(cmdText, conn);

                // 리소스 열기
                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();
                
                // 커서의 위치를 한칸씩 이동
                while (rdr.Read())
                {
                    string id = rdr["Id"] as string;
                    string password = rdr["Password"] as string;
                    string name = rdr[2] as string;
                    int age = (int)rdr[3];

                    Console.WriteLine("id: " + id + ", passowrd: " + password + ", name: " + name + ", age: " + age);
                }
                rdr.Close();
            }

            SqlDataReader rdr2 = GetDataReader(connString, cmdText);
            // DataReader 객체의 Close() 호출시 연결되어있는 Connection 객체의 리소스를 닫는다.
            rdr2.Close();

        }

        // DataReader 리소스를 닫은 후 Connection 리소스를 닫아야 하는데,
        // DataReader 리소스를 닫기전 코드 블럭이 끝나 Connection 객체에 접근할 방법이 없다.
        static SqlDataReader GetDataReader(string connString, string cmdText)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            conn.Open();

            //Connection Leak 예방법
            SqlDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return rdr;
        }
    }
}
