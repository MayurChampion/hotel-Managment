<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ado.net.RegistrationSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url(img/login.jpg);background-repeat:no-repeat;background-size:cover">
    <div  style="width:300px; padding:35px; height:150px;  border-radius:15px;color:white;box-shadow:2px 2px 10px white;margin-top:15%;margin-left:35%;">
      <form id="form1" runat="server">
         <table align="center">
                  <tr>
                    <td colspan="2" align="center"><h2 style=" color:black;"><u>Login</u></h2></td>
                 </tr>
               <tr>
                   <td style=" color:black;font-size:20px;">Username</td>
                    <td><asp:TextBox ID="txtuser" runat="server" /></td>
               </tr>
               <tr>
                   <td style=" color:black;font-size:20px;">password</td>
                   <td><asp:TextBox ID="txtpassw" runat="server" TextMode="Password" /></td>
               </tr>
              <tr>
                  <td colspan="2" align="center"><asp:Button ID="btnlogin" runat="server" Text="Login" ForeColor="#990000" BackColor="#ffff00" OnClick="btnlogin_Click"/></td>
              </tr>
             <tr>
                 <td><asp:Label ID="lbl" runat="server" /></td>
             </tr>
         </table>
      </form>
    </div>
</body>
</html>
