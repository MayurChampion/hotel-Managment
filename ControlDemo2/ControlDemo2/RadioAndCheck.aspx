<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioAndCheck.aspx.cs" Inherits="ControlDemo2.RadioAndCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:
            <asp:TextBox ID="txtName" runat="server" /><br />
            Gender:
            <asp:RadioButton GroupName="gender" ID="rbMale" runat="server" Text="Male" />
            <asp:RadioButton GroupName="gender" ID="rbFemale" runat="server" Text="Female" />
            <asp:RadioButton GroupName="gender" ID="rbTrans" runat="server" text="Transgender" /><br />
            Eating Habbit:
            <asp:RadioButton GroupName="habbit" ID="rbVeg" runat="server" Text="vegetarian" />
            <asp:RadioButton GroupName="habbit" ID="rbNonveg" runat="server" Text="Non-Vegetarian" />
            <asp:RadioButton GroupName="habbit" ID="rbVegan" runat="server" Text="Vegan" /> <br />
            Hobbies
            <asp:CheckBox ID="cbReading" runat="server" Text="Reading Book" />
            <asp:CheckBox ID="cbPlaying" runat="server" Text="Playing Games" />
            <asp:CheckBox ID="cbWatching" runat="server" Text="Watching Movies" /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Label ID="lblMsg"  runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
