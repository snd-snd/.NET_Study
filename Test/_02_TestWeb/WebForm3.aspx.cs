using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_TestWeb
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            Response.Write("Page_Load<br>");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit<br>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init<br>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender<br>");
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            Response.Write("Page_Render<br>");
        }

        protected void Page_SaveState(object sender, EventArgs e)
        {
            Response.Write("Page_SaveState<br>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page_PreLoad<br>");
        }
        

    }
}