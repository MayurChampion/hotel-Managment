<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ColourDilog.aspx.cs" Inherits="WebForm2.ColourDilog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div1" runat="server"> 
            
            <asp:TextBox runat="server" AutoPostBack="true" TextMode="Color" ID="color1"  OnTextChanged="Color1_Textchanged"/> 
            <asp:TextBox  runat="server" TextMode="DateTimeLocal"  ID="TextBox1"/> <br /><br />
            <asp:TextBox  runat="server" TextMode="Month"  ID="TextBox2"/> <br /><br />
            <asp:TextBox  runat="server" TextMode="Email" ID="TextBox3"/> <br /><br />
            <asp:TextBox  runat="server" TextMode="MultiLine"  ID="TextBox4"/> <br /><br />
            <asp:TextBox  runat="server" TextMode="Number"  ID="TextBox5"/> <br /><br />
            <asp:TextBox  runat="server" TextMode="Password" ID="TextBox6"/> <br /><br />
             <asp:TextBox  runat="server" TextMode="Search" ID="TextBox7"/> <br /><br />
            <asp:TextBox  runat="server" TextMode="Date"  ID="TextBox8"/> <br /><br />
              <asp:TextBox  runat="server" TextMode="Week"  ID="TextBox9"/> <br /><br />
        </div>
       <%-- <asp:Button ID="btn" runat="server" Text="button" />--%>
    </form>
</body>
</html>
