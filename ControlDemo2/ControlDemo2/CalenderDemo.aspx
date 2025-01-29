<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalenderDemo.aspx.cs" Inherits="ControlDemo2.CalenderDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select Data
            <asp:TextBox ID="txt1" runat="server"/>
            <asp:ImageButton ID="btnDate" runat="server" ImageUrl="~/images/calender.jpg" Width="40" Height="40"  ImageAlign="AbsMiddle" OnClick="btnDate_Click"/>
            <asp:Calendar ID="cldDate" runat="server" Caption="Date Picker" DayNameFormat="Full" OnSelectionChanged="cldDate_SelectionChanged"/>
            </div>
    </form>
</body>
</html>
