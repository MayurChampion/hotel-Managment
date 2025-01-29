<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextBoxControlTextChange.aspx.cs" Inherits="ControlDemo2.TextBoxControlTextChange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="div1" runat="server">
            <br />
              Change Color:
                <asp:TextBox ID="txtColor1" runat="server" TextMode="Color" AutoPostBack="true" OnTextChanged="txtColor1_TextChanged" /><br /><br />
            </div>
           
        </div>
    </form>
</body>
</html>
