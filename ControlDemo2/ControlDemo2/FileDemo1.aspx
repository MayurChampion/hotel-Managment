﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileDemo1.aspx.cs" Inherits="ControlDemo2.FileDemo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:Button ID="btn1" runat="server"  Text="Upload file" OnClick="btn1_Click"/>
             <br />
            <asp:Label ID="lbl1" runat="server" ForeColor="Red"/>
        </div>
    </form>
</body>
</html>
 