<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 37px; top: 47px; position: absolute" Text="Customer Id"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 156px; top: 47px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerFullNm" runat="server" style="z-index: 1; left: 37px; top: 78px; position: absolute; height: 13px; width: 96px" Text="Full name "></asp:Label>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 154px; top: 77px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 37px; top: 108px; position: absolute" Text="Email Address"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 153px; top: 106px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblShippingAdd" runat="server" style="z-index: 1; left: 34px; top: 140px; position: absolute; width: 107px" Text="Shipping Address"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 151px; top: 135px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 34px; top: 175px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 149px; top: 174px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateReg" runat="server" style="z-index: 1; left: 35px; top: 211px; position: absolute" Text="Date Register"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 150px; top: 207px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 35px; top: 250px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 40px; top: 286px; position: absolute"></asp:Label>
        <asp:Button ID="BttnOk" runat="server" style="z-index: 1; left: 38px; top: 316px; position: absolute" Text="OK" />
        <asp:Button ID="bttnCancel" runat="server" style="z-index: 1; left: 79px; top: 316px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
