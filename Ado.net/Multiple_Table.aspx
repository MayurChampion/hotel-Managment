<%@ Page Language="C#" AutoEventWireup="true" Codefile="Multiple_Table.aspx.cs" Inherits="Ado.net.Multiple_Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="gvdepartment" runat="server" />
            
            <hr />
            <asp:GridView ID="gvemp" runat="server" />
           
        </div>
    </form>
</body>
</html>
