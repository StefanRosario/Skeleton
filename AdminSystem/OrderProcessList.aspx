
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" style="z-index: 1; left: 13px; top: 417px; position: absolute" Text="Add" />
        <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" style="z-index: 1; left: 55px; top: 417px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 454px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 106px; top: 416px; position: absolute" Text="Delete" />
        <asp:ListBox ID="lstOrderList" runat="server" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged" style="z-index: 1; left: 8px; top: 32px; position: absolute; height: 381px; width: 557px"></asp:ListBox>
    </form>
</body>
</html>
