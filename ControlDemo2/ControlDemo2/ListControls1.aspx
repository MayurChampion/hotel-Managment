<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListControls1.aspx.cs" Inherits="ControlDemo2.ListControls1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

              <h5>DropDownList</h5>

            <asp:DropDownList ID="DropDownList1" runat="server">
                 
                 
                <asp:ListItem Value="c1">india</asp:ListItem>
                <asp:ListItem Value="c2">japan</asp:ListItem>
                <asp:ListItem Value="c3">china</asp:ListItem>
               
                <asp:ListItem Text="swedan" Value="c4" />
               <asp:ListItem Text="france" Value="c5" />
                <asp:ListItem Text="america" Value="c6" />
                
              </asp:DropDownList>

        </div>
        <div>
              <h5>CheckBoxList</h5>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatLayout="UnorderedList">    <%--RepeatDirection="Horizontal", RepeatLayout="UnorderedList",RepeatLayout="orderedList"RepeatDirection="Vertical"--%>
              
              
               <asp:ListItem Text="Red" value="color1"/>
               <asp:ListItem Text="Blue" Value="color2" />
               <asp:ListItem Text="Yellow" valu1="color3" />


               <asp:ListItem Value="color4">Whaite</asp:ListItem>
              <asp:ListItem Value="color5">Black</asp:ListItem>
              <asp:ListItem Value="color6">green</asp:ListItem>
          
        </asp:CheckBoxList>
        </div>
        <div>
                <h5>RadioButtonList</h5>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">    <%--RepeatDirection="Horizontal", RepeatDirection="Vertical"--%>
                  
                
                <asp:ListItem Text="Delhi" Value="s1" />
                 <asp:ListItem Text="Maharastra" Value="s2"/>
                 <asp:ListItem Text="Telangana" Value="s3"/>

              <asp:ListItem Value="s4">Mumbai</asp:ListItem>
                <asp:ListItem Value="s5">AP</asp:ListItem>
                <asp:ListItem Value="s6">MP</asp:ListItem>
            
            </asp:RadioButtonList>
        </div>
        <div>
                    <h5>ListBox</h5>
            
            <asp:ListBox ID="ListBox1" runat="server">   <%-- SelectionMode="Multiple",SelectionMode="Single"--%>

         
                <asp:ListItem  Text="Mayur" Value="b1"/>
                <asp:ListItem Text="Bhushan" Value="b2"/>
                <asp:ListItem Text="Vishal" Value="b3" />

                <asp:ListItem Value="b4">Atual</asp:ListItem>
                <asp:ListItem Value="b5">Saurab</asp:ListItem>
                <asp:ListItem Value="b6">vivek</asp:ListItem>

            </asp:ListBox>
        </div>
        
    </form>
</body>
</html>
