<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 283px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="TblProductID" runat="server" style="z-index: 1; left: 10px; top: 18px; position: absolute" Text="ProductID"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 79px; top: 17px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="tblProductName" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; right: 570px" Text="ProductName"></asp:Label>
        </p>
        <p>
            <asp:Label ID="tblDescription" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Description"></asp:Label>
&nbsp;<asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 93px; top: 91px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="tblCategory" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Category"></asp:Label>
        </p>
        <p>
            <asp:Label ID="tblPrice" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Price"></asp:Label>
        </p>
        <p>
            <asp:Label ID="tblStockCount" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute" Text="StockCount"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 12px; top: 241px; position: absolute" Text="Available" />
        </p>
        <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 105px; top: 52px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCategory" runat="server" style="z-index: 1; top: 127px; position: absolute; left: 75px; margin-top: 1px"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 57px; top: 166px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStockCount" runat="server" style="z-index: 1; left: 97px; top: 204px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 264px; position: absolute; margin-top: 9px"></asp:Label>
    </form>
</body>
</html>
