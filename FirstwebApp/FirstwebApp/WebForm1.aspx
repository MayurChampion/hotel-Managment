<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FirstwebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Server Datec:
            <% Response.Write(DateTime.Now.ToShortDateString()); %>
            <br/>
            Server Time:
            <% Response.Write(DateTime.Now.ToLongTimeString()); %>
        </div>
    </form>
</body>
</html>
