<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="WebForm2.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption><font size="5" color="orange">Login Form</font></caption>
                <tr>
                    <td>Enter Name:</td>
                    <td><asp:TextBox ID="txtName" runat="server" /></td>
                </tr>
                <tr>
                    <td>Enter Pasword:</td>
                    <td><asp:TextBox ID="TxtPwd" TextMode="Password" MaxLength="10" runat="server" /></td>
                </tr>
                <tr>
                    <td>Enter email:</td>
                    <td><asp:TextBox ID="TxtEmail" TextMode="Email" runat="server" /></td>
                </tr>
                <tr>
                    <td colspan="2"align="center">
                        <asp:Button ID="btn1" runat="server" Text="submit" OnClick="btn1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="reset" OnClick="Button2_Click" />
                    </td>
                </tr>
                <tr>
                     <td colspan="2">
                        <asp:Label ID="lblStatus" runat="server" ForeColor="YellowGreen"/>
                       </td>
                 </tr>
            </table>
           
        </div>
    </form>
</body>
</html>
