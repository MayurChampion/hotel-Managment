<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculatr.aspx.cs" Inherits="WebForm2.Calculatr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .mayur{
                border:double;
                border-block-color:green;
                border-radius:10px;
              
               }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table  size="100px" class ="mayur" align="center">
            <caption> <font size="4" color="red">Calculator</font></caption>
            <tr>
                <td>
                    <asp:Label ID="lblNum1"  runat="server" Text="Enter 1<sup>st</sup> Number:"/>

                </td>
                <td>
                    <asp:TextBox ID="txtNum1" runat="server"/> 
                </td>
            </tr>
             <tr>
                <td>
                     <asp:Label ID="lblNum2" runat="server" Text="Enter 2<sup>nd</sup> Number:"/>
                  </td>
                   <td>
                       <asp:TextBox ID="txtNum2" runat="server"/>
                   </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblResult" runat="server"  Text="Result Obtained:"/>
                </td>
                <td>
                    <asp:TextBox ID="txtResult" runat="server"/>
                 </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btn1" runat="server" Text="ADD" OnClick="btn1_Click" />
                    <asp:Button ID="btn2"  runat="server" Text="SUM" OnClick="btn1_Click"/>
                    <asp:Button ID="btn3" runat="server" Text="MUL"  OnClick="btn1_Click"/>
                     <asp:Button ID="btn4"  runat="server" Text="DIV" OnClick="btn1_Click"/>
                     <asp:Button ID="btn5"  runat="server" Text="MOD" OnClick="btn1_Click"/>
                 </td>
            </tr>
        </table>
         </div>
    </form>
</body>
</html>
