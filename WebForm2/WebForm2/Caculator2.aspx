<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Caculator2.aspx.cs" Inherits="WebForm2.Caculator2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table size="100px" align="center">
                    <caption><font size="4" color="red">Calculator2</font></caption>
                    <tr>
                        <td>
                            <asp:Label ID="lblNum1" runat="server" Text="Enter 1<sup>st</sup> Number:" />

                       </td>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNum1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblNum2" runat="server" Text="Enter 2<sup>nd</sup> Number:" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtNum2" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblResult" runat="server" Text="Result Obtained:" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtResult" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="center">
                            <asp:Button ID="btn1" runat="server" Text="ADD" OnCommand="Buttons_Command" CommandName="+" />
                            <asp:Button ID="btn2" runat="server" Text="SUM" OnCommand="Buttons_Command" CommandName="-" />
                            <asp:Button ID="btn3" runat="server" Text="MUL" OnCommand="Buttons_Command" CommandName="*" />
                            <asp:Button ID="btn4" runat="server" Text="DIV" OnCommand="Buttons_Command" CommandName="/" />
                            <asp:Button ID="btn5" runat="server" Text="MOD" OnCommand="Buttons_Command" CommandName="%" />
                        </td>
                    </tr>
                </table>
            </ContentTemplate> 
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
