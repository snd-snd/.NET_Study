<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebForms.Board.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>쓰기</title>
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.4.1.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
      <div class="form-group">
        <label for="Title">Title:</label>
        <asp:TextBox ID="Title" runat="server" class="form-control"></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="Writer">Writer:</label>
          <asp:TextBox ID="Writer" runat="server" class="form-control"></asp:TextBox>
      </div>
      <div class="form-group">
        <label for="Content">Content</label>
          <asp:TextBox ID="Content" runat="server" class="form-control" TextMode="MultiLine" Rows="6"></asp:TextBox>
      </div>
        <asp:Button ID="btnRegister" class="btn btn-primary" runat="server" Text="Button" OnClick="btnRegister_Click"/>
    </div>

    </form>
</body>
</html>
