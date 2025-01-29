<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArithmeticOper.aspx.cs" Inherits="ControlDemo2.ArithmeticOper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="border:2px solid red">
            <asp:Label ID="lbl1" runat="server" Text="Enter The First Number:" />
            <asp:TextBox ID="txt1" runat="server"/><br><br><br>
            <asp:Label ID="lbl2" runat="server" Text="Enter The Second Number:" />
            <asp:TextBox ID="txt2" runat="server" /><br><br><br>
            <asp:TextBox ID="lbl3" runat="server" /><br><br><br>
            <asp:Button ID="btn" runat="server" OnClick="btn_Click" Text="Addition" />
        </div>
    </form>
</body>
</html>
