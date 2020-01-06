using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;

namespace _00_ExampleApp
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            string connectionInfo = "server = localhost,1433; uid = sa; pwd = 1234; database = basic;";
            SqlConnection conn = new SqlConnection(connectionInfo);

            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;

            string sql = "insert into member (id,name,age) values(@param1,@param2,@param3)";

            comm.CommandText = sql;

            comm.Parameters.AddWithValue("@param1", "kim");
            comm.Parameters.AddWithValue("@param2", "김태호");
            comm.Parameters.AddWithValue("@param3", 29);

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("성공");
        }
    }
}
