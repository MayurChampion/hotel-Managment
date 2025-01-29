<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration_success.aspx.cs" Inherits="Ado.net.registration_success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Registration Successful</h2>
            <p>Click on Login button to check details.</p>
            <asp:Button ID="btn" runat="server" Text="Login" OnClick="btn_Click" />
        </div>
    </form>
</body>
</html>
