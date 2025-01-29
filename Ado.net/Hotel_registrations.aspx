<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hotel_registrations.aspx.cs" Inherits="Ado.net.Hotel_registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url(img/hotel.jpg);background-repeat:no-repeat;background-size:cover">
    <div style="width:350px; padding:30px; height:150px; border-radius:15px;color:white;box-shadow:2px 2px 10px black;margin-top:15%;margin-left:35%;">
    <form id="form1" runat="server">
        <div>
            <table>
                  <tr>
                    <td colspan="2" align="center"><h2 style=" color:darkred;">hotel registration</h2></td>
                 </tr>
                <tr>
                    <td style=" color:black;font-size:20px;"> UserNmae </td>
                    <td><asp:TextBox ID="txtUser" runat="server" /></td>
                </tr>
                <tr>
                    <td style=" color:black;font-size:20px;"> Room Type </td>
                    <td><asp:RadioButton ID="radiobtn1" GroupName="rt" runat="server" Text="Delux"  ForeColor="White" />
                        <asp:RadioButton ID="radiobtn2" runat="server" GroupName="rt" Text="ordinary"  ForeColor="White"/>
                    </td>

                </tr>
                <tr>
                    <td  style=" color:black;font-size:20px;"> Amenities </td>
                    <td> 
                        <asp:CheckBox ID="CheckBox1"   runat="server" Text="AC"  ForeColor="White"/>
                      
                         <asp:CheckBox ID="CheckBox2" runat="server" Text="Computer"  ForeColor="White" />

<%--                                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                                 <asp:ListItem Text="AC" Value="1"></asp:ListItem>
                                   <asp:ListItem Text="Computer" Value="2"></asp:ListItem>
                                 
                                </asp:CheckBoxList>--%>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center"> <asp:Button ID="regbtn" runat="server" Text="Register" ForeColor="#990000" BackColor="#ffff00" OnClick="regbtn_Click"/> </td>
                </tr>
            </table>
        </div>
    </form>
  </div>
</body>
</html>
