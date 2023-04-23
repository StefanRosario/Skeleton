<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 283px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 178px; top: 21px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 574px; top: 12px; position: absolute" Text="Find" />
        </div>
        <asp:Label ID="TblProductID" runat="server" style="z-index: 1; left: 10px; top: 18px; position: absolute" Text="Product ID" width="69px"></asp:Label>
        <p>
            <asp:Label ID="lblProductName" runat="server" height="19px" style="z-index: 1; left: 10px; top: 53px; position: absolute; width: 94px" Text="Product Name"></asp:Label>
        </p>
        <p>
            <asp:Label ID="tblDescription" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute" Text="Description" height="19px"></asp:Label>
&nbsp;<asp:TextBox ID="txtDescription" runat="server" style="z-index: 1; left: 93px; top: 91px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="tblPrice" runat="server" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Price" height="19px" width="69px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="tblStockCount" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute; width: 82px;" Text="Stock Count" height="19px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="tblCategory" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Category" height="19px" width="69px"></asp:Label>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 973px; top: 440px; position: absolute" Text="View Stock" />
        </p>
        <p>
            <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 12px; top: 241px; position: absolute; width: 109px;" Text="Available" height="19px" />
        </p>
        <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 105px; top: 51px; position: absolute; margin-top: 1px;"></asp:TextBox>
        <asp:TextBox ID="txtCategory" runat="server" style="z-index: 1; top: 127px; position: absolute; left: 75px; margin-top: 1px"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 57px; top: 166px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStockCount" runat="server" style="z-index: 1; left: 127px; top: 216px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 264px; position: absolute; margin-top: 9px" height="19px" width="69px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 62px; top: 506px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 231px; top: 515px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
