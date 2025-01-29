<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ControlDemo2.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" style="border:2px solid red;border-radius:10px;background-color:aqua">
                 <caption style="color:crimson">Login Form</caption>
                <tr>
                    <th>UserName :</th>
                    <td><asp:TextBox ID="txt1" runat="server" /></td>
                </tr>
                <tr>
                    <th>Passward :</th>
                    <td><asp:TextBox  ID="txt2" runat="server" TextMode="Password"/></td>
                </tr>
                <tr align="center">
                    <td><asp:Button ID="btn" runat="server" BorderColor="YellowGreen" Text="Login" OnClick="btn_Click"/></td>
                    <td><asp:Button ID="btn2" runat="server"  BorderColor="YellowGreen" Text="Reset" OnClick="btn2_Click"/></td>
                </tr>
                
            </table>
        </div>
    </form>
</body>
</html>
