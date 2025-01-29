<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonDemo1.aspx.cs" Inherits="ControlDemo2.ButtonDemo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn1" runat="server" Text="Click Me" />
            <asp:LinkButton ID="btn2" runat="server" Text="Click Me" />
            <asp:imageButton ID="btn3" runat="server"  ImageUrl="~/images/MI.jpg" Width="100" Height="100"/>
        </div>
    </form>
</body>
</html>
