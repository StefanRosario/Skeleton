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
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 108px; top: 27px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 11px; top: 68px; position: absolute; width: 70px; height: 19px;" Text="CustomerID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 109px; top: 63px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 11px; top: 103px; position: absolute; width: 70px" Text="OrderDate"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 109px; top: 97px; position: absolute; height: 22px;"></asp:TextBox>
        <asp:Label ID="lblTotalCost" runat="server" style="z-index: 1; left: 16px; top: 141px; position: absolute; width: 70px" Text="TotalCost"></asp:Label>
        <asp:TextBox ID="txtTotalCost" runat="server" style="z-index: 1; left: 108px; top: 140px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblShippingAddress" runat="server" style="z-index: 1; left: 15px; top: 176px; position: absolute; width: 70px; right: 819px;" Text="Shipping Address"></asp:Label>
        <asp:TextBox ID="txtShippingAddress" runat="server" style="z-index: 1; top: 185px; position: absolute; left: 108px"></asp:TextBox>
        <asp:CheckBox ID="chkShipped" runat="server" style="z-index: 1; left: 12px; top: 252px; position: absolute" Text="Shipped" OnCheckedChanged="chkShipped_CheckedChanged" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 298px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 18px; top: 337px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 59px; top: 336px; position: absolute" Text="CANCEL" OnClick="btnCancel_Click" />
        <p>
&nbsp;<asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 9px; top: 29px; position: absolute; height: 20px; width: 70px; right: 825px" Text="OrderID"></asp:Label>
        </p>
        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" style="z-index: 1; left: 284px; top: 25px; position: absolute" Text="Find" />
    </form>
</body>
</html>
