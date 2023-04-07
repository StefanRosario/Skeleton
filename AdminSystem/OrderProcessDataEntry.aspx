<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 105px; top: 180px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCostumerID" runat="server" style="z-index: 1; left: 11px; top: 68px; position: absolute; width: 70px" Text="CostumerID"></asp:Label>
        <asp:TextBox ID="txtCostumerID" runat="server" style="z-index: 1; left: 109px; top: 63px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 11px; top: 103px; position: absolute; width: 70px" Text="OrderDate"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 109px; top: 97px; position: absolute; height: 22px;"></asp:TextBox>
        <asp:Label ID="lblTotalCost" runat="server" style="z-index: 1; left: 16px; top: 141px; position: absolute; right: 432px; width: 70px" Text="TotalCost"></asp:Label>
        <asp:TextBox ID="txtTotalCost" runat="server" style="z-index: 1; left: 108px; top: 140px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblShippingAddress" runat="server" style="z-index: 1; left: 8px; top: 19px; position: absolute; width: 70px; right: 826px;" Text="Shipping Address"></asp:Label>
        <asp:TextBox ID="txtShppingAddress" runat="server" style="z-index: 1; top: 25px; position: absolute; left: 113px"></asp:TextBox>
        <asp:CheckBox ID="chkShipped" runat="server" style="z-index: 1; left: 12px; top: 252px; position: absolute" Text="Shipped" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 298px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 18px; top: 337px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 59px; top: 336px; position: absolute" Text="CANCEL" />
        <p>
&nbsp;<asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 14px; top: 182px; position: absolute; height: 20px; width: 70px; right: 598px" Text="OrderID"></asp:Label>
        </p>
        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" style="z-index: 1; left: 273px; top: 179px; position: absolute" Text="Find" />
    </form>
</body>
</html>
