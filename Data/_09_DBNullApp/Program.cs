using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _09_DBNullApp
{
    class Program
    {     
        public static SqlDataReader GetReader()
        {
            string connString = "server = .; database = Example; uid = origin; pwd = 1234;";
            string cmdText = "select hit from board where bno = 1";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            conn.Open();
            // null 필드가 리턴된다고 가정
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        static void Main(string[] args)
        {
            SqlDataReader rs = GetReader();
            rs.Read();

            // rs[0] == null은 항상 false
            if (rs[0] == null)
            {
                // 아래 문장은 어떠한 경우에도 실행될 수 없다.
                Console.WriteLine("Field is Null");
            }
            else
            {
                // System.DBNull
                Type type = rs[0].GetType();
                Console.WriteLine("Field Type : " + type);

                // String.Empty == ""
                string value = rs[0].ToString();
                Console.WriteLine("Field Value : " + value);
            }

            // rs[0]은 null이 아니기에 ToString()을 사용할 수 있다.
            if (rs[0].ToString() == string.Empty)
            {
                Console.WriteLine("Field Value is String.Empty");
            }
            DBNull a = DBNull.Value;

            rs.Close();
        }
    }
}
