using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _04_DataAdapterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 연결 정보
            string connString = "server = localhost,1433; database = data; uid=kkorison; pwd=1234;";
            string cmdText = "select * from Members";

            SqlConnection conn = new SqlConnection(connString);               
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, conn);
                
            DataSet ds = new DataSet();

            // Fill 호출시 자동으로 리소스를 열고 사용 후 닫는다.
            adapter.Fill(ds);
            
            DataTable table = ds.Tables[0];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                string id = table.Rows[i]["Id"].ToString();
                string pwd = table.Rows[i]["Password"].ToString();
                string name = table.Rows[i]["Name"].ToString();
                string age = table.Rows[i]["Age"].ToString();

                Console.WriteLine("id: "+id+", pwd: "+pwd+", name: "+name+", age: "+age);
            }
        }
    }
}
