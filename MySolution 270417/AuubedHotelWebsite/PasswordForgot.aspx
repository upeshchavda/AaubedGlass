﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PasswordForgot.aspx.cs" Inherits="PasswordForgot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" SuccessPageUrl="Login.aspx">
        </asp:PasswordRecovery>
    
    </div>
    </form>
</body>
</html>
