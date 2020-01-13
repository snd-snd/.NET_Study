using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Example_Board_Register : System.Web.UI.Page
{

    private string connString = string.Empty;
    private string cmdText = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonRegister_Click(object sender, EventArgs e)
    {
        connString = "server=.; database=example; uid=origin; pwd=1234;";
        cmdText = "select * from board";

        using (SqlConnection conn = new SqlConnection(connString))
        using (SqlCommand cmd = new SqlCommand(cmdText, conn))
        {
            conn.Open();

            var reader = cmd.ExecuteReader();
            var list = new List<Board>();

            while (reader.Read())
            {
                long? bno = reader["Bno"] as long?;
                string title = reader["Title"] as string;
                string writer = reader["Writer"] as string;
                string content = reader["Content"] as string;
                string regdate = reader["Regdate"] as string;
                int? hit = reader["Hit"] as int?;

                Board board = new Board() {Bno = bno.Value, Title = title, Writer = writer, Content = content, Regdate = regdate, Hit = hit.Value };
                list.Add(board);
            }



        }
        

        
    }
}