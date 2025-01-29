<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BtnDemo4.aspx.cs" Inherits="ControlDemo2.BtnDemo4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function GetConformation()
        {
            var Result = confirm("are you submit");
            return Result;
        } 
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn1" runat="server" Text="Click me" OnClick="btn1_Click"  OnClientClick="return GetConformation()"/>
            <asp:Label ID="lbl1" runat="server" />
        </div>
    </form>
</body>
</html>
