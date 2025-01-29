<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextChange.aspx.cs" Inherits="ControlDemo2.TextChange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt" runat="server" AutoPostBack="true" textmode="Phone" OnTextChanged="txt_TextChanged" /> <%-- 16 textmode , AutoPostBack="true" means automatic sbmit the server--%>
            <asp:Label ID="lbl" runat="server" Text="" />
            <asp:Button id="btn" runat="server"/>
          </div>
        <div id="div1" runat="server">
  <br />Change Color: <asp:TextBox ID="txtColor1" runat="server" TextMode="Color" /><br /><br />
</div>
<asp:Button ID="Button1" runat="server" Text="Button" />

    </form>
</body>
</html>
