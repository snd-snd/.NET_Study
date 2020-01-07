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
            Response.Write(DateTime.Now.ToLongTimeString()+"</br>");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("PreInit</br>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Init</br>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("PreRender</br>");
        }

    }
}