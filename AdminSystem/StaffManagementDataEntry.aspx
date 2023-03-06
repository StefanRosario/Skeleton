<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 48px;
        }
        #Form2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="IblAddressNo" runat="server" Text="Address Number"></asp:Label>
        <asp:TextBox ID="txtAddressNo" runat="server" Height="22px" width="105px"></asp:TextBox>
        <p id="Form2">
            <asp:Label ID="IblHouseNo" runat="server" Text="House No" width="105px"></asp:Label>
            <asp:TextBox ID="txtHouseNo" runat="server" width="105px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblStreet" runat="server" Text="Street" width="105px"></asp:Label>
            <asp:TextBox ID="txtStreet" runat="server" width="105px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblTown" runat="server" Text="Town" width="105px"></asp:Label>
            <asp:TextBox ID="txtTown" runat="server" width="105px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblPostCode" runat="server" Text="Post Code" width="105px"></asp:Label>
            <asp:TextBox ID="txtPostCode" runat="server" width="105px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblCounty" runat="server" Text="County" width="105px"></asp:Label>
            <asp:TextBox ID="txtCounty" runat="server" width="105px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblDateAdded" runat="server" Text="Date Added" width="105px"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server" width="105px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" OnCheckedChanged="chkActive_CheckedChanged" />
        </p>
        <p>
            <asp:Label ID="IblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
