<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationField2.aspx.cs" Inherits="ControlDemo2.ValidationField2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:aqua">
    <form id="form1" runat="server">
        <div>
            <table align="center" style="background-color:brown">
                <caption><font size="5" color="red">Book My Ticket</font></caption>
                <tr>
                    <td style="color:aliceblue">
                        <asp:Label ID="Label1" runat="server" Text="Enter Name      : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" /></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RVFName" runat="server" ControlToValidate="txtName" Display="Dynamic" ErrorMessage="Name Field Can Not Be Empty Left" ForeColor="Red" SetFocusOnError="True" /></td>
                </tr>
                <tr>
                    <td  style="color:aliceblue">
                        <asp:Label ID="Label2" runat="server" Text="Enter The Age   : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server" /></td>
                    <td>
                        <asp:RequiredFieldValidator ID="rvfAge" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="Age Field Can Not be Left Empty" ForeColor="Red" SetFocusOnError="True" /><br />
                        <asp:RangeValidator ID="rvAge" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="Traveler's age should be  between 18-65 years" ForeColor="Red" MaximumValue="65" MinimumValue="18" SetFocusOnError="True" Type="Integer" />
                    </td>
                </tr>
                <tr>
                    <td  style="color:aliceblue">
                        <asp:Label ID="Label3" runat="server" Text="Data of Journey : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDate" runat="server" />
                        <asp:ImageButton ID="imgbtn" runat="server" ImageUrl="~/images/calender.jpg" Width="20" Height="20" ImageAlign="AbsMiddle" OnClick="imgbtn_Click" ValidationGroup="DateGroup" /> <%-- ValidationGroup="DateGroup"  not Depended on any other   --%>
                        <asp:Calendar ID="cld" runat="server" Visible="false" OnSelectionChanged="cld_SelectionChanged" />

                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rvf3" runat="server" ControlToValidate="txtDate" Display="Dynamic" ErrorMessage="Date Field Can Not be Empty" ForeColor="Red" SetFocusOnError="True" />
                        <br />
                        <asp:RangeValidator ID="rvDate" runat="server" ControlToValidate="txtDate" Display="Dynamic" ErrorMessage=" Travel date should be with-in 90 days from current date" ForeColor="Red" SetFocusOnError="True" Type="Date" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnConfirm" runat="server" Text="Confirm Booking" OnClick="btnConfirm_Click" /></td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan="3"align="center">
                        <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    </td>

                </tr>
            </table>

        </div>
    </form>
</body>
</html>
