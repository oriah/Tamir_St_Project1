<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="MuaiTai.Web.Pages.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        label#lblStatus {
            color: red
        }

        div, hr {
            margin-bottom: 20px
        }
    </style>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login</h1>
        <hr />
        <asp:Label ID="lblStatus" runat="server" Visible="False"></asp:Label>
        <div>
            <asp:Label runat="server">User Name: </asp:Label>
            <asp:TextBox ID="tbxUserName" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label runat="server">Password: </asp:Label>
            <asp:TextBox ID="tbxPassword" runat="server"></asp:TextBox>

        </div>

        <asp:Button runat="server" OnClick="Btn_Click" Text="Log In" />
    </form>
</body>
</html>
