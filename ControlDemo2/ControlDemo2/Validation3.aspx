<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation3.aspx.cs" Inherits="ControlDemo2.Validation3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption><font size="5" color="red">Registration Form</font></caption>
                <tr>
                    <td>
                        <asp:Label ID="lbl1" runat="server" Text="Enter The Name :" />
                    </td>
                    <td>
                         <asp:TextBox ID="txtName" runat="server" />
                    </td>
                    <td>
                         <asp:RequiredFieldValidator ID="rvfName" runat="server" ControlToValidate="txtName" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ErrorMessage="Name field can't be left empty."/>
                    </td>
                    </tr>
                     <tr>
                    <td>
                        <asp:Label ID="labl2" runat="server" Text="Enter The Password :" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rvfpwd" runat="server" ErrorMessage=" Confirm password field can't be left empty." ControlToValidate="txtPwd" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl3" runat="server" Text="Confirm Password :" />
                      
                    </td>
                    <td>
                        <asp:TextBox ID="txtCpwd" runat="server"  />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rvfCpwd" runat="server" ErrorMessage=" : Confirm password field can't be left empty.." Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtCpwd" />
                        <br />
                         <asp:CompareValidator ID="cvfpwd" runat="server" ErrorMessage="Confirm password should match with password." Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ControlToCompare="txtPwd" ControlToValidate="txtCpwd" />

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl4" runat="server" Text="Date Of Birth" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtDate" runat="server" />
                        <asp:Calendar ID="cldDate" runat="server" Visible="false" ImageAlign="AbsMiddle" ValidationGroup="DateGroup" OnSelectionChanged="cal_SelectionChanged" />
                        <asp:ImageButton ID="imgbtn" runat="server" ImageUrl="~/images/calender.jpg" Width="20" Height="25" ValidationGroup="DateGroup" OnClick="imgbtn_Click"/>
                    </td>
                    <td>
                          <asp:CompareValidator ID="cvDate" runat="server" ErrorMessage="Entered value should be in MM/DD/YYYY." Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtDate" Operator="DataTypeCheck" Type="Date" />
                            <br />
                          <asp:CompareValidator ID="cvMajor" runat="server" ErrorMessage="You need to attain 18 years of age for registration" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtDate" Type="Date" />

                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center"> 
                        <asp:Button ID="btn" runat="server" Text="Register" OnClick="RegBtn" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center">
                        <asp:Label ID="lblMsg" runat="server"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
