<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationControl1.aspx.cs" Inherits="ControlDemo2.ValidationControl1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            Enter Name:
            <asp:TextBox ID="txtName" runat="server" />
             <asp:RequiredFieldValidator ID="rfvName" runat="server"  ControlToValidate="txtName" ForeColor="Red" Text="Name field can not be left empty." Display="Dynamic"  SetFocusOnError="true"></asp:RequiredFieldValidator>
               Select Countries : 
            <asp:DropDownList ID="ddlContries" runat="server">
                   <asp:ListItem Text="-Select Countries-" Value="NS"/>
                    <asp:ListItem Text="SWEDEN" Value="1"/>
                    <asp:ListItem Text="MAHARASTRA" Value="2"/>
                    <asp:ListItem Text="USA" Value="3"/>
                    <asp:ListItem Text="CANDA" Value="4"/>
               </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvCountry" runat="server" ControlToValidate="ddlContries" ForeColor="Red" Display="Dynamic"  ErrorMessage="select your countries from the list" SetFocusOnError="true" InitialValue="NS " ></asp:RequiredFieldValidator>  <%--InitialValue means Dont consider this  value--%>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Label ID="lbl" runat="server" />
        </div>
    </form>
</body>
</html>
