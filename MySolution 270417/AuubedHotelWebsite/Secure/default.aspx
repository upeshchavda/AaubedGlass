<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="Secure_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="lblUserInfo" runat="server" Text="Username"></asp:Label>
    <br />
    <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
    <div>
        <a href="../ChangePassword.aspx">Change Password</a>

    </div>
    </form>
</body>
</html>
