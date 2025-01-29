<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBox_RadioButton.aspx.cs" Inherits="ControlDemo2.CheckBox_RadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption> <font size="5" color="red">Registration Form</font></caption>
                <tr>
                    <td>Full Name : </td>
                    <td>
                        <asp:TextBox ID="txt1" runat="server" /></td>

                </tr>
                <tr>
                    <td>Education</td>
                    <td>
                        <asp:TextBox ID="txt2" runat="server" /></td>
                </tr>
                <tr>

                    <td>Select Course : </td>
                    <td>
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="course" Text=".Net Full Stack"/>
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="course"  Text="JAVA Full Stack"/>  <%--in form radiobutton in more than one group so how to identify this is which group so use GroupName="" property--%>
                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="course" Text="Python Full Stack"/>

                    </td>
                </tr>
                <tr>
                    
                    <td>Gender : </td>
                    <td>
                        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="gender" Text="Male"/>
                        <asp:RadioButton ID="RadioButton5" runat="server" GroupName="gender"  Text="Female" />
                        <asp:RadioButton ID="RadioButton6" runat="server" GroupName="gender"  Text="Other"/>
                    </td>
                </tr>
                <tr align="center">
                    <td colspan="2"><asp:Button ID="btn1" runat="server" Text="Submit" OnClick="btn1_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2"> <asp:Label ID="lbl1" runat="server" /></td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
