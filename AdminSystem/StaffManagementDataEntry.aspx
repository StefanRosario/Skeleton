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
        <asp:Label ID="IblStaffID" runat="server" Text="Staff ID" width="48px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffID" runat="server" Height="19px" width="120px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p id="Form2">
            <asp:Label ID="IblUsername" runat="server" Text="Username" width="48px" height="19px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsername" runat="server" width="120px" height="19px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblPassword" runat="server" Text="Password" width="48px" height="19px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPassword" runat="server" width="120px" height="19px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblRole" runat="server" Text="Role" width="48px" height="19px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRole" runat="server" width="120px" height="19px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IblDateAdded" runat="server" Text="Date Added" width="48px" height="19px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDateAdded" runat="server" width="120px" height="19px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" OnCheckedChanged="chkActive_CheckedChanged" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
