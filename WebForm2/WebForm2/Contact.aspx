<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm2.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption><font size="6" color="green"> customer Contact</font></caption>
                <tr>
                    <td> Name : </td>
                    <td><asp:TextBox ID="txtName" runat="server"  /></td>
                </tr> 
                <tr>
                    <td> Phone No : </td>
                    <td> <asp:TextBox ID="txtPhone" runat="server" /></td>
                </tr>
                <tr>
                    <td>Email : </td>
                    <td> <asp:TextBox ID="txtEmail" runat="server" /></td>
                </tr>
                
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btn1" runat="server" Text="SUBMIT" PostBackUrl="~/Response.aspx"/>
                        <asp:Button ID="btn2" runat="server" Text="RESET" OnClick="btn2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
