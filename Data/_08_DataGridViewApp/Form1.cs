using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_DataGridViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String connString = "server = (local); database = data; uid = kkorison; pwd = 1234;";
            String cmdText = "select * from Members";
            SqlDataAdapter da = new SqlDataAdapter(cmdText, connString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DataTable dt = new DataTable();

            DataTable dtMember = (DataTable)dataGridView1.DataSource;

            dt = dtMember.GetChanges(DataRowState.Modified);


        }




    }
}
