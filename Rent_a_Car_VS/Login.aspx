<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Rent_a_Car_VS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Пријави се!<br />
            Имејл адреса:
            <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
            <br />
            Лозинка:
            <asp:TextBox ID="txt_lozinka" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btn_login" runat="server" OnClick="btn_login_Click" Text="У реду" />
        </div>
    </form>
</body>
</html>
