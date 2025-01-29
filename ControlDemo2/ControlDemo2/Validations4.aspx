<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validations4.aspx.cs" Inherits="ControlDemo2.Validations4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" >
                <caption><font size="5" color="red">Company Registration Form</font></caption>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Enter Company Name"></asp:Label>
                    </td>
                    <td>
                       
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td><asp:RequiredFieldValidator ID="rvfName" runat="server" ErrorMessage="Comapany name field can't be left empty." ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Enter your Contact"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
                  
                    </td>
                    <td>  <asp:RegularExpressionValidator ID="rvf2" runat="server"  ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^\d{6,8}$|^[6-9]\d{9}$"
                                       ErrorMessage="Contact no. can either be Land Phone (6-8 digits) or Mobile (10 digits)."></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Enter your Email"></asp:Label>
                    </td>
                    <td><asp:TextBox ID="TextBox3" runat="server"  TextMode="Email"/>
                    </td>
                    <td><asp:RegularExpressionValidator ID="rvf3" runat="server"  ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"  ErrorMessage=" Given input is an invalid Email Id format." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Website Url"></asp:Label>
                    </td>
                    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox> </td>
                    <td><asp:RegularExpressionValidator ID="rvf4" runat="server" ErrorMessage="Given input is an invalid Website Url format." ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="3"align="center"><asp:Button ID="btn1" runat="server" Text="Register" OnClick="btn1_Click" /> </td>
                   
                </tr>
                <tr>
                    <td colspan="3" align="center"><asp:Label ID="lblmsg" runat="server" /></td>
                    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
