using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms.Board
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            BoardDataContext db = new BoardDataContext();

            board board = new board();
            board.title = Title.Text;
            board.writer = Writer.Text;
            board.content = Content.Text;
            board.regdate = DateTime.Now;
            
            board.hit = 0;

            db.board.InsertOnSubmit(board);
            db.SubmitChanges();

            Response.Redirect("List.aspx");
        }
    }
}