<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Aspdb_Customer_GridView_Sort.aspx.cs" Inherits="Ado.net.Aspdb_Customer_GridView_Sort" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"  AllowSorting="true"  OnSorting="GridView1_Sorting"/>

        </div>
    </form>
</body>
</html>
