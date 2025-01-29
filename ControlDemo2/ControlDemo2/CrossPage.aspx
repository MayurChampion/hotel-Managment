<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrossPage.aspx.cs" Inherits="ControlDemo2.CrossPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
   <caption>Contact Details</caption>
   <tr>
      <td>Name:</td>
      <td><asp:TextBox ID="txtName" runat="server" /></td>
   </tr>
   <tr>
      <td>Phone No:</td>
      <td><asp:TextBox ID="txtPhone" runat="server" MaxLength="10" /></td>
   </tr>
   <tr>
      <td>Email Id:</td>
      <td><asp:TextBox ID="txtEmail" runat="server" TextMode="Email" /></td>
   </tr>
   <tr>
      <td colspan="2" align="center">
         <asp:Button ID="btnSubmit" runat="server" Text="Submit" PostBackUrl="~/Respond.aspx"/>
         <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
      </td>
   </tr>
</table>


        </div>
    </form>
</body>
</html>
