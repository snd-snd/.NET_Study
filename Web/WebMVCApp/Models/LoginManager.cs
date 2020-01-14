using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebMVCApp.Models
{
    public class LoginManager
    {
        public static bool LoginCheck(String id, String password)
        {
            String connString = "server = .; database = Example; uid = origin; pwd = 1234;";
            int a = 100;
            String cmdText = "SELECT NULL FROM board where hit = 100";

            if (id != null)
            {
                a = Convert.ToInt32(id);
                cmdText = "SELECT NULL FROM board where hit = " + a.ToString();
            }

 


            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                var result = cmd.ExecuteScalar();

                return result != null;
            }




        }
    }
}