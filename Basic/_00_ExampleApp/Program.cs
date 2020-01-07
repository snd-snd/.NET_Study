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
            string connectionInfo = "server = localhost,1433; uid = study; pwd = 1234; database = study;";
            SqlConnection conn = new SqlConnection(connectionInfo);

            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;

            string sql = "insert into member (name,age) values(@param1,@param2)";

            comm.CommandText = sql;

            comm.Parameters.AddWithValue("@param1", "김태호");
            comm.Parameters.AddWithValue("@param2", 29);

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("성공");

        }
    }
}
