using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    private String connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
    private String sql = "select * from member";

    public String Id { get; set; }
    public String Password { get; set; }
    public String Name { get; set; }
    public String Email { get; set; }

    public DataTable dt { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                dt = new DataTable();
                dt.Load(reader);
            }
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}