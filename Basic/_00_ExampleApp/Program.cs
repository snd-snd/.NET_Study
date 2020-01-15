using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using Microsoft.ApplicationBlocks.Data;

namespace _00_ExampleApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            String url = Run();
            Console.WriteLine(url);
        }

        internal static String Run()
        {
            String connectionString = "server=.;database=origin;uid=origin;pwd=1234;";
            String sql = "select getdate()";
            String url = String.Empty;

            try
            {
                using (SqlDataReader dr = SqlHelper.ExecuteReader(connectionString, CommandType.Text, sql))
                {
                    if (dr.HasRows)
                    {
                        dr.Read();
                        url = dr[0].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }

            return url;
        }
    }

    
}
