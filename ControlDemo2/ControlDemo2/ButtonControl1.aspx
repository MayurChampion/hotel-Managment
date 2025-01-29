<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="ButtonControl1.aspx.cs" Inherits="ControlDemo2.ButtonControl1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:aqua">
    <form id="form1" runat="server">
        <div id="div1" runat="server">
           <table align="center"  style="border:double;background-color:brown;border-color:black;margin-top:200px">
               <tr>
                <td>1<sup>st</sup>Number</td>
                <td ><asp:TextBox ID="txt1" runat="server" ForeColor="Black" /></td>
                  
                </tr>
               <tr>
                   <td>2<sup>nd</sup> Number</td>
                   <td><asp:TextBox ID="txt2" runat="server" ForeColor="Black"/></td>
                   
               </tr>
                <tr align="center">
                    <td colspan="2"> 
                        <asp:Button ID="btn1" runat="server" text="ADD" OnClick="btn1_Click"/>
                        <asp:Button ID="btn2" runat="server" text="SUB" OnClick="btn1_Click"/>
                        <asp:Button ID="btn3" runat="server" text="MUL" OnClick="btn1_Click"/>
                        <asp:Button ID="btn4" runat="server" text="MOD" OnClick="btn1_Click"/>
                    </td>
                </tr>
               <tr>
                   <td colspan="2"><asp:Label ID="lbl1" runat="server" /></td>
               </tr>
           </table>
        </div>
    </form>
</body>
</html>
