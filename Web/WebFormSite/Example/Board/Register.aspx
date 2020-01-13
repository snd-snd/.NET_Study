<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Example_Board_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelTitle" runat="server" Text="Title"></asp:Label>
        <asp:TextBox ID="TextBoxTitle" runat="server" Width="748px"></asp:TextBox>
        <br />
        <asp:Label ID="LabelWriter" runat="server" Text="writer"></asp:Label>
        <asp:TextBox ID="TextBoxWriter" runat="server" Width="748px"></asp:TextBox>
        <br />
        <asp:Label ID="LabelContent" runat="server" Text="content"></asp:Label>
        <asp:TextBox ID="TextBoxContent" runat="server" Width="748px" TextMode="MultiLine" Rows="6"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonRegister" runat="server" Text="Register" OnClick="ButtonRegister_Click" />
    </div>
    </form>
</body>
</html>
