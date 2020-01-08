<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_02_TestWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="버튼1" OnClick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="버튼2" PostBackUrl="~/WebForm2.aspx"/>
    </div>
    </form>
</body>
<script runat="server">
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("다시게시: " + TextBox1.Text);
    }

</script>
</html>
