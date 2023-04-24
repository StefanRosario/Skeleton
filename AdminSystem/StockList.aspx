<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="z-index: 1; left: 16px; top: 16px; position: absolute; height: 327px; width: 733px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="248px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 159px; top: 822px; position: absolute"></asp:Label>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 10px; top: 915px; position: absolute" Text="Apply" />
        </p>
        <p>
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 10px; top: 1063px; position: absolute" Text="Clear" />
            <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 10px; top: 471px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 454px; top: 388px; position: absolute" Text="Edit" />
        </p>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 271px; top: 384px; position: absolute" Text="Delete" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
