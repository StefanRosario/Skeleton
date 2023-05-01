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
        <p>
            <asp:TextBox ID="CustomerIdTxt" runat="server" style="z-index: 1; left: 150px; top: 47px; position: absolute; width: 140px;" height="22px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerFullNm" runat="server" style="z-index: 1; left: 37px; top: 78px; position: absolute; height: 13px; width: 92px" Text="Full name "></asp:Label>
        </p>
        <asp:TextBox ID="FullNameTxt" runat="server" style="z-index: 1; left: 150px; top: 77px; position: absolute; width: 140px;" height="22px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 37px; top: 108px; position: absolute" Text="Email Address" width="92px"></asp:Label>
        <asp:TextBox ID="EmailTxt" runat="server" style="z-index: 1; left: 151px; top: 106px; position: absolute; width: 140px;" height="22px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <asp:Label ID="lblShippingAdd" runat="server" style="z-index: 1; left: 34px; top: 140px; position: absolute; width: 92px" Text="Shipping Address"></asp:Label>
        <asp:TextBox ID="ShippingAddressTxt" runat="server" style="z-index: 1; left: 151px; top: 141px; position: absolute; width: 140px;" height="22px"></asp:TextBox>
        <asp:Label ID="lblPhoneNo" runat="server" style="z-index: 1; left: 35px; top: 176px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="PhoneNumberTxt" runat="server" style="z-index: 1; left: 151px; top: 177px; position: absolute; width: 140px;"></asp:TextBox>
        <asp:Label ID="lblDateReg" runat="server" style="z-index: 1; left: 35px; top: 211px; position: absolute" Text="Date Register" width="92px"></asp:Label>
        <asp:TextBox ID="DateRegisterTxt" runat="server" style="z-index: 1; left: 149px; top: 216px; position: absolute; height: 22px; width: 140px;"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 34px; top: 244px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 39px; top: 273px; position: absolute"></asp:Label>
        <asp:Button ID="BttnOk" runat="server" style="z-index: 1; left: 16px; top: 336px; position: absolute" Text="OK" OnClick="BttnOk_Click" />
        <asp:Button ID="bttnCancel" runat="server" style="z-index: 1; left: 68px; top: 337px; position: absolute; height: 26px; width: 58px;" Text="Cancel" OnClick="bttnCancel_Click" />
        <p>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 37px; top: 47px; position: absolute; width: 92px;" Text="Customer Id"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="FindBttn" runat="server" style="z-index: 1" Text="Find" OnClick="FindBttn_Click" />
        </p>
    </form>
</body>
</html>
