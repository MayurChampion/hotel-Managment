<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Aspdb_Customer_GridView_Paging.aspx.cs" Inherits="Ado.net.Customer_GridView_Paging" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:GridView ID="gvCustomers" runat="server" AllowPaging="true" PageSize="3" OnPageIndexChanging="gvCustomers_PageIndexChanging" />
        </div>
    </form>
</body>
</html>
 