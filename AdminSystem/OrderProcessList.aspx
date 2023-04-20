
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
        <asp:Button ID="btnAdd" runat="server" OnClick="BtnAdd_Click" style="z-index: 1; left: 13px; top: 417px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="BtnEdit_Click" style="z-index: 1; left: 55px; top: 417px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 5px; top: 585px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 106px; top: 416px; position: absolute" Text="Delete" />
        <asp:Label ID="LblShippingAddress" runat="server" style="z-index: 1; left: 13px; top: 462px; position: absolute" Text="Enter a Shipping Address"></asp:Label>
        <asp:Button ID="btnClear" runat="server" OnClick="BtnClear_Click" style="z-index: 1; left: 78px; top: 499px; position: absolute" Text="Clear" />
        <asp:ListBox ID="lstOrderList" runat="server" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged" style="z-index: 1; left: 8px; top: 32px; position: absolute; height: 381px; width: 557px"></asp:ListBox>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 180px; top: 458px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="BtnApply_Click" style="z-index: 1; left: 12px; top: 499px; position: absolute; right: 1424px; height: 25px;" Text="Apply" />
    </form>
</body>
</html>
