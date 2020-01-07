using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _01_ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //while(true)
            //{
            //    Console.WriteLine("1, 2");
            //    ConsoleKeyInfo key = Console.ReadKey(true);

            //    if (key.KeyChar == '2') break;


            //    Console.Write("이름: ");
            //    string name = Console.ReadLine();
            //    Console.Write("나이: ");
            //    int age = Convert.ToInt32(Console.ReadLine());

            //    string connectionString = "server = localhost,1433; uid = study; pwd = 1234; database = study";

            //    SqlConnection conn = new SqlConnection(connectionString);

            //    SqlCommand command = new SqlCommand();
            //    command.Connection = conn;
            //    command.CommandText = "insert into member (name, age) values (@param1, @param2)";

            //    command.Parameters.AddWithValue("@param1", name);
            //    command.Parameters.AddWithValue("@param2", age);

            //    conn.Open();
            //    command.ExecuteNonQuery(); 
            //    conn.Close();

            //    Console.WriteLine("success");
            //}

            string connectionString = "server = localhost,1433; uid = study; pwd = 1234; database = study";

            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select * from member";
            conn.Open();
            SqlDataReader rdr = command.ExecuteReader();
            

            List<MemberVO> list = new List<MemberVO>();
            while (rdr.Read())
            {
                long no = (long)rdr["no"];
                string name = rdr["name"] as string;
                int age = (int)rdr["age"];

                list.Add(new MemberVO { No = no, Name = name, Age = age });
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("success");

            conn.Close();
        }
    }
}
