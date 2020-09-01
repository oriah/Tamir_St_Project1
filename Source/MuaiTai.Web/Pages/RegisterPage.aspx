<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="MuaiTai.Web.Pages.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script></script>
    <style>
        label#lblStatus {
            color: red
        }

        div,hr {
            margin-bottom: 20px
        }

    </style>
    <title>Register</title>
</head>
<body>
    <h1>Register</h1>
    <hr />
    <form id="form1" runat="server">
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
        <div>
            <asp:Label runat="server">User Name: </asp:Label>
            <asp:TextBox ID="tbxUserName" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label runat="server">Password: </asp:Label>
            <asp:TextBox ID="tbxPassword" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label runat="server">FirstName: </asp:Label>
            <asp:TextBox ID="tbxFirstName" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label runat="server">LastName: </asp:Label>
            <asp:TextBox ID="tbxLastName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server">PhoneNumber: </asp:Label>
            <asp:TextBox ID="tbxPhoneNumber" runat="server"></asp:TextBox>

        </div>

        <asp:Button runat="server" OnClick="Btn_Click" />
    </form>
</body>
</html>
