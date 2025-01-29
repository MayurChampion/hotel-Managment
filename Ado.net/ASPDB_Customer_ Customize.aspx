<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ASPDB_Customer_ Customize.aspx.cs" Inherits="Ado.net.ASPDB_Customer__Customize" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"  HorizontalAlign="Center" Caption="Customer Details" AutoGenerateColumns="false"> <%--HorizontalAlign="Center"  this property use align center ,right ,left  //  AutoGenerateColumns="false" this property by default true and we can genrate our oun so use false --%>
                 <%--<HeaderStyle BackColor="Yellow" ForeColor="Red" />
                  <RowStyle BackColor="Tan" ForeColor="Teal" />
                  <AlternatingRowStyle BackColor="Teal"  ForeColor="Teal" />--%>
                 <%-- 3 use all column same style than use--%>
                <Columns>
                        <asp:BoundField DataField="Custid" HeaderText="ID" ItemStyle-HorizontalAlign="center" HeaderStyle-BackColor="Yellow" HeaderStyle-ForeColor="Red" ItemStyle-BackColor="gray" ItemStyle-ForeColor="aqua"/>
                        <asp:BoundField DataField="Names" HeaderText="Name"  HeaderStyle-BackColor="Yellow" HeaderStyle-ForeColor="Red" ItemStyle-BackColor="gray" ItemStyle-ForeColor="aqua"/>
                        <asp:BoundField DataField="Balance" HeaderText="Balance" ItemStyle-HorizontalAlign="Right" HeaderStyle-BackColor="Yellow" HeaderStyle-ForeColor="Red" ItemStyle-BackColor="gray" ItemStyle-ForeColor="aqua"/>
                        <asp:BoundField DataField="City"  HeaderStyle-BackColor="Yellow" HeaderStyle-ForeColor="Red" ItemStyle-BackColor="gray" ItemStyle-ForeColor="aqua"/>
                       <%--<asp:CheckBoxField DataField="status"  HeaderText="IsActive" ItemStyle-HorizontalAlign="center"  HeaderStyle-BackColor="Yellow" HeaderStyle-ForeColor="Red" ItemStyle-BackColor="gray" ItemStyle-ForeColor="aqua" /> --%>
                   <asp:TemplateField HeaderTexT="IsActive"  ItemStyle-HorizontalAlign="center" HeaderStyle-BackColor="Yellow" HeaderStyle-ForeColor="Red" ItemStyle-BackColor="gray" ItemStyle-ForeColor="aqua">
                            <ItemTemplate>
                                 <asp:RadioButton ID="rbStatus" runat="server"  Enabled="true" Checked='<% # Eval("Status")%>' /> <%--Enabled="true" mens edit or readonly mode--%>
                            </ItemTemplate>
             </asp:TemplateField>
             </Columns>
           </asp:GridView>
        </div>
    </form> 
</body>
</html>

<%--by default every colun algnis left  numeric value is right--%>
<%--BoundField default field it will do what  it will check of  data type of column  and genrate base on means string and editmode genrate textbox ,readonly so genrate label--%>
<%--we will genrate  any other control use TemplateField like dropdown--%>
<%--ItemTemplate read only mode use and editmode use EdititemTemplate--%>
