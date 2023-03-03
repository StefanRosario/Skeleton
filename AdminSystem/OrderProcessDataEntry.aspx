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
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 10px; top: 30px; position: absolute" Text="Shipping Address"></asp:Label>
        <asp:TextBox ID="TxtAddressNo" runat="server" style="z-index: 1; left: 128px; top: 30px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCostumerId" runat="server" style="z-index: 1; left: 14px; top: 68px; position: absolute" Text="CostumerID"></asp:Label>
        <asp:TextBox ID="intCostumer" runat="server" style="z-index: 1; left: 111px; top: 66px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCost" runat="server" style="z-index: 1; left: 17px; top: 108px; position: absolute" Text="Total Cost"></asp:Label>
        <asp:TextBox ID="IntCost" runat="server" style="z-index: 1; left: 95px; top: 108px; position: absolute"></asp:TextBox>
        <asp:Label ID="lbldate" runat="server" style="z-index: 1; left: 13px; top: 151px; position: absolute" Text="Order Date"></asp:Label>
        <asp:TextBox ID="date" runat="server" style="z-index: 1; left: 93px; top: 151px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblOrder" runat="server" style="z-index: 1; left: 16px; top: 190px; position: absolute; margin-bottom: 0px" Text="OrderID"></asp:Label>
        <asp:TextBox ID="intOrderID" runat="server" style="z-index: 1; left: 92px; top: 190px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="Shipped" runat="server" style="z-index: 1; left: 17px; top: 256px; position: absolute" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 319px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 22px; top: 372px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 63px; top: 372px; position: absolute; right: 1280px" Text="CANCEL" />
    </form>
</body>
</html>
