<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ASPDB_Customer_Select.aspx.cs" Inherits="Ado.net.ASPDB_Customer_Select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption>Customer Details</caption>
                <tr>
                    <td>Customer Id:</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server" /></td>
                </tr>
                <tr>
                    <td>Customer Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" /></td>
                </tr>
                <tr>
                    <td>Customer Balance:</td>
                    <td>
                        <asp:TextBox ID="txtBalance" runat="server" /></td>
                </tr>
                <tr>
                    <td>Customer City:</td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server" /></td>
                </tr>
                <tr>
                    <td>Customer Status:</td>
                    <td>
                        <asp:CheckBox ID="cbStatus" runat="server" /></td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnFirst" runat="server" Text="First" Width="50" OnClick="btnFirst_Click" />
                        <asp:Button ID="btnPrev" runat="server" Text="Prev" Width="50" OnClick="btnPrev_Click" />
                        <asp:Button ID="btnNext" runat="server" Text="Next" Width="50" OnClick="btnNext_Click" />
                        <asp:Button ID="btnLast" runat="server" Text="Last" Width="50" OnClick="btnLast_Click"/>
                    </td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
