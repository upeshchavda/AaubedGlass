﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ChangePassword ID="ChangePassword1" runat="server" CancelDestinationPageUrl="Login.aspx" DisplayUserName="True" SuccessPageUrl="secure/Default.aspx" UserName="<%UserName%>">
        </asp:ChangePassword>
    
    </div>
    </form>
</body>
</html>
