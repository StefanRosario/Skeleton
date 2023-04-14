<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="444px" OnSelectedIndexChanged="lstStaffList_SelectedIndexChanged" Width="504px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
