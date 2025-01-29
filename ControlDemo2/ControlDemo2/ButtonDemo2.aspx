<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonDemo2.aspx.cs" Inherits="ControlDemo2.ButtonDemo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn1" runat="server" Text="postback submission"/>
            <asp:Button ID="btn2" runat="server" Text="crosspage submission" PostBackUrl="~/ButtonDemo1.aspx"/> 
        </div>
    </form>
</body>
</html>
