using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_TestWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TextBox1.Text = "값을 입력하시오.";
            }
            
            
            
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Console.WriteLine("PreInit 요청");
            System.Diagnostics.Debug.WriteLine("메시지");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Console.WriteLine("init 요청");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Console.WriteLine("PreRender 요청");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(TextBox1.Text);
        }


    }
}