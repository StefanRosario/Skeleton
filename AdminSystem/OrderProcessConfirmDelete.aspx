﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteThisRecord" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 13px; top: 63px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 59px; top: 63px; position: absolute" Text="No" />
    </form>
</body>
</html>
